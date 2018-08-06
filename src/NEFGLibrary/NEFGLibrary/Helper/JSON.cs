using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

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
  }
}