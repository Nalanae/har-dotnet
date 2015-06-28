using Newtonsoft.Json;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Represents the state of the browser cache.
    /// </summary>
    public class CacheState : HarEntityBase
    {
        /// <summary>
        /// Expiration time of the cache entry.
        /// </summary>
        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// The last time the cache entry was opened.
        /// </summary>
        [JsonProperty("lastAccess")]
        public DateTime LastAccess { get; set; }

        /// <summary>
        /// Etag value.
        /// </summary>
        [JsonProperty("eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// The number of times the cache entry has been opened.
        /// </summary>
        [JsonProperty("hitCount")]
        public int HitCount { get; set; }
    }
}