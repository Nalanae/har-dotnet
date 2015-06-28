using Newtonsoft.Json;

namespace HttpArchive
{
    /// <summary>
    /// Represents changes in the browser cache.
    /// </summary>
    public class Cache : HarEntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cache"/> class.
        /// </summary>
        public Cache()
        {
            BeforeRequest = new CacheState();
            AfterRequest = new CacheState();
        }

        /// <summary>
        /// State of a cache entry before the request.
        /// </summary>
        [JsonProperty("beforeRequest", NullValueHandling = NullValueHandling.Ignore)]
        public CacheState BeforeRequest { get; set; }

        /// <summary>
        /// State of a cache entry after the request.
        /// </summary>
        [JsonProperty("afterRequest", NullValueHandling = NullValueHandling.Ignore)]
        public CacheState AfterRequest { get; set; }
    }
}