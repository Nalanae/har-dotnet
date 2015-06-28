using Newtonsoft.Json;

namespace HttpArchive
{
    /// <summary>
    /// Represents a general HTTP parameter (cookie, header, query).
    /// </summary>
    public class Parameter : HarEntityBase
    {
        /// <summary>
        /// The name of the parameter.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the parameter.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}