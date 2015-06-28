using Newtonsoft.Json;

namespace HttpArchive
{
    /// <summary>
    /// Represents timings for various events (states) fired during the page load. All times are specified in milliseconds.
    /// </summary>
    public class PageTimings : HarEntityBase
    {
        /// <summary>
        /// Content of the page loaded. Number of milliseconds since page load started (page.startedDateTime).
        /// </summary>
        [JsonProperty("onContentLoad", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnContentLoad { get; set; }

        /// <summary>
        /// Page is loaded (onLoad event fired). Number of milliseconds since page load started (page.startedDateTime).
        /// </summary>
        [JsonProperty("onLoad", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnLoad { get; set; }
    }
}