using Newtonsoft.Json;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Represents an HTTP cookie.
    /// </summary>
    public class Cookie : Parameter
    {
        /// <summary>
        /// The path pertaining to the cookie.
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// The host of the cookie.
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// Cookie expiration time.
        /// </summary>
        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Set to true if the cookie is HTTP only, false otherwise.
        /// </summary>
        [JsonProperty("httpOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HttpOnly { get; set; }

        /// <summary>
        /// True if the cookie can only be transmitted over ssl, false otherwise.
        /// </summary>
        [JsonProperty("secure", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Secure { get; set; }
    }
}