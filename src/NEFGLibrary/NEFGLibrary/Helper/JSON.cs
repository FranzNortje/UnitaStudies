using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NEFGLibrary.Helper
{
  public static class Json
  {
    private static string SerializeArgumentNullException(object value)
    {
      var argument = (ArgumentNullException) value;
      return JsonConvert.SerializeObject(new Dictionary<string, string> {
        {"ExceptionType", typeof(ArgumentNullException).ToString()},
        {"Source", argument.Source},
        {"Message", argument.Message},
        {"Parameter", argument.ParamName},
        {"StackTrace", argument.StackTrace}
      }, JsonSettings.Strict);
    }

    private static string SerializeArgumentException(object value)
    {
      var argument = (ArgumentException) value;
      return JsonConvert.SerializeObject(new Dictionary<string, string> {
        {"ExceptionType", typeof(ArgumentException).ToString()},
        {"Source", argument.Source},
        {"Message", argument.Message},
        {"Parameter", argument.ParamName},
        {"StackTrace", argument.StackTrace}
      }, JsonSettings.Strict);
    }

    /// <summary>
    ///   Converts object to its JSON representation
    /// </summary>
    /// <param name="value">Value to convert to JSON</param>
    /// <param name="setting"></param>
    /// <returns>Serialized JSON string</returns>
    public static string Stringify(object value, JsonSerializerSettings setting)
    {
      return JsonConvert.SerializeObject(value, setting);
    }

    /// <summary>
    ///   Converts object to its JSON representation
    /// </summary>
    /// <param name="value">Value to convert to JSON</param>
    /// <param name="indentation">Indentation (default 4)</param>
    /// <returns>Serialized JSON string</returns>
    public static string StringifyIndented(object value, int indentation = 4)
    {
      using (var sw = new StringWriter())
      using (var jw = new JsonTextWriter(sw))
      {
        jw.Formatting = Formatting.Indented;
        jw.IndentChar = ' ';
        jw.Indentation = indentation;

        var serializer = JsonSerializer.Create(JsonSettings.Strict);
        serializer.Serialize(jw, value);
        return sw.ToString();
      }
    }

    /// <summary>
    ///   Converts an object to its JSON representation (extension method for Stringify)
    /// </summary>
    /// <param name="value">
    ///   Object
    /// </param>
    /// <returns>
    ///   JSON representation string.
    /// </returns>
    /// <remarks>
    ///   null, Int32, Boolean, DateTime, Decimal, Double, Guid types handled automatically.
    ///   If object has a ToJson method it is used, otherwise value.ToString() is used as last fallback.
    /// </remarks>
    public static string ToJson(this object value)
    {
      return Stringify(value);
    }

    /// <summary>
    ///   Converts object to its JSON representation
    /// </summary>
    /// <param name="value">Value to convert to JSON</param>
    /// <returns>Serialized JSON string</returns>
    public static string Stringify(object value)
    {
      if (value is ArgumentNullException) return SerializeArgumentNullException(value);
      if (value is ArgumentException) return SerializeArgumentException(value);

      return JsonConvert.SerializeObject(value, JsonSettings.Strict);
    }

    public static Dictionary<string, object> DeserializeAndFlatten(string json)
    {
      var dict = new Dictionary<string, object>();
      try
      {
        JToken token = JToken.Parse(json);
        FillDictionaryFromJToken(dict, token, "");
      }
      catch (JsonReaderException e)
      {
        // Logger<>.LogErrorEvent("Failed to parse json.", details: e);
        return null;
      }

      return dict;
    }

    public static bool IsValidJson(string strInput)
    {
      strInput = strInput.Trim();
      if (string.IsNullOrWhiteSpace(strInput)) return false;
      if (strInput.Equals("{}")) return false;

      if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
          (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
      {
        try
        {
          var obj = JToken.Parse(strInput);
          return true;
        }
        catch (JsonReaderException jex)
        {
          //Exception in parsing json
          Console.WriteLine(jex.Message);
          return false;
        }
      }
      else
      {
        return false;
      }
    }

    private static void FillDictionaryFromJToken(Dictionary<string, object> dict, JToken token, string prefix)
    {
      switch (token.Type)
      {
        case JTokenType.Object:
          foreach (JProperty prop in token.Children<JProperty>())
          {
            FillDictionaryFromJToken(dict, prop.Value, Join(prefix, prop.Name));
          }

          break;

        case JTokenType.Array:
          var index = 0;
          foreach (JToken value in token.Children())
          {
            FillDictionaryFromJToken(dict, value, Join(prefix, index.ToString()));
            index++;
          }

          break;
        default:
          if (dict.ContainsKey(prefix))
          {
            dict.Add($"{prefix}/{Guid.NewGuid()}", ((JValue) token).Value);
          }
          else
          {
            dict.Add(prefix, ((JValue) token).Value);
          }

          break;
      }
    }

    private static string Join(string prefix, string name)
    {
      return (string.IsNullOrEmpty(prefix) ? name : prefix + "." + name);
    }

    public abstract class JsonTextBuilder
    {
      public abstract JsonTextBuilder StartObject(string objectName = null);
      public abstract JsonTextBuilder StartObjectArray(string objectName = null);
      public abstract JsonTextBuilder WriteProperty(string fieldName, object fieldValue);
      public abstract JsonTextBuilder EndObjectArray();
      public abstract JsonTextBuilder EndObject();
      public abstract string Build();
    }

    public class Builder : JsonTextBuilder, IDisposable
    {
      private readonly StringBuilder _stringBuilder;
      private readonly StringWriter _stringWriter;
      private readonly JsonTextWriter _writer;

      public Builder()
      {
        _stringBuilder = new StringBuilder(250);
        _stringWriter = new StringWriter(_stringBuilder);
        _writer = new JsonTextWriter(_stringWriter);
        _writer.WriteStartObject();
      }


      public override JsonTextBuilder StartObject(string objectName = null)
      {
        if (objectName != null)
        {
          _writer.WritePropertyName(objectName);
        }

        _writer.WriteStartObject();
        return this;
      }

      public override JsonTextBuilder StartObjectArray(string objectName = null)
      {
        if (objectName != null)
        {
          _writer.WritePropertyName(objectName);
        }

        _writer.WriteStartArray();
        _writer.WriteStartObject();
        return this;
      }

      public override JsonTextBuilder WriteProperty(string fieldName, object fieldValue)
      {
        _writer.WritePropertyName(fieldName);
        _writer.WriteValue(fieldValue);
        return this;
      }

      public override JsonTextBuilder EndObjectArray()
      {
        _writer.WriteEndArray();
        _writer.WriteEndObject();
        return this;
      }

      public override JsonTextBuilder EndObject()
      {
        _writer.WriteEndObject();
        return this;
      }

      public override string Build()
      {
        _writer.WriteEndObject();
        _writer.Flush();
        _writer.Close();
        return _stringBuilder.ToString();
      }

      public void Dispose()
      {
        _writer?.Flush();
        _writer?.Close();
        _stringWriter?.Dispose();
        ((IDisposable) _writer)?.Dispose();
      }
    }
  }
}

/*
 * Example of JBuilder in action:
 *
   return jBuilder
        .WriteProperty(FieldNames.ActionFieldName, FieldNames.FreeGamesAddUserToFreeGameAction)
        .WriteProperty(FieldNames.ProductIdFieldName, evt.UserContext.ProductId)
        .WriteProperty(FieldNames.UserIdFieldName, evt.UserContext.UserId)       
        .WriteProperty(FieldNames.OfferId, offerId)
        .StartObject(FieldNames.RequestFieldName)
          .WriteProperty(FieldNames.IdempotencyIdFieldName, idempotencyId)
          .WriteProperty(FieldNames.OfferAvailableFromUtcDate, utcNow)
        .EndObject()        
        .Build();
      
      //{
      //"action":"FreeGamesAddUserToFreeGame",
      //"productId":5007,
      //"userId":6,
      //"offerId": 6, 
      //"request":{
      //  "idempotencyId": "55623a3a-43d9-4072-8434-1c6234f10322",
      //  "offerAvailableFromUtcDate": "05/02/2017 09:34:42 PM"
      //  }
      //}       

  */