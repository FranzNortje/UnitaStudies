using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NEFGLibrary.Helper
{
  public static class JsonSettings
  {
    public static JsonSerializerSettings AutoNaming;
    public static JsonSerializerSettings Strict;
    public static JsonSerializerSettings Tolerant;

    static JsonSettings()
    {
      Tolerant = new JsonSerializerSettings {
        DateParseHandling = DateParseHandling.DateTimeOffset,
        NullValueHandling = NullValueHandling.Ignore,
        MissingMemberHandling = MissingMemberHandling.Ignore,
        TypeNameHandling = TypeNameHandling.None,
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        PreserveReferencesHandling = PreserveReferencesHandling.None
      };
      Tolerant.Converters.Add(new IsoDateTimeConverter());
      Tolerant.Converters.Add(new JsonSafeInt64Converter());

      AutoNaming = new JsonSerializerSettings {
        TypeNameHandling = TypeNameHandling.Auto
      };
      AutoNaming.Converters.Add(new IsoDateTimeConverter());
      AutoNaming.Converters.Add(new JsonSafeInt64Converter());

      Strict = new JsonSerializerSettings {
        DateParseHandling = DateParseHandling.DateTimeOffset,
        NullValueHandling = NullValueHandling.Ignore,
        MissingMemberHandling = MissingMemberHandling.Error,
        TypeNameHandling = TypeNameHandling.None,
        ReferenceLoopHandling = ReferenceLoopHandling.Error,
        PreserveReferencesHandling = PreserveReferencesHandling.None
      };
      Strict.Converters.Add(new IsoDateTimeConverter());
      Strict.Converters.Add(new JsonSafeInt64Converter());
    }
  }
}