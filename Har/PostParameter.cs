using Newtonsoft.Json;

namespace HttpArchive
{
    /// <summary>
    /// Represents a parameter in an HTTP POST call.
    /// </summary>
    public class PostParameter : Parameter
    {
        /// <summary>
        /// Name of a posted file.
        /// </summary>
        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// Content type of a posted file.
        /// </summary>
        [JsonProperty("contentType", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }
    }
}