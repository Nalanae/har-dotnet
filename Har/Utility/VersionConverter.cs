using Newtonsoft.Json;
using System;

namespace HttpArchive.Utility
{
    internal class VersionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Version);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var versionString = (string)reader.Value;
            return new Version(versionString);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var version = (Version)value;
            writer.WriteValue(version.ToString());
        }
    }
}