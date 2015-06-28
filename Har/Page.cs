using Newtonsoft.Json;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Represents an exported (tracked) page.
    /// </summary>
    public class Page : HarEntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Page"/> class.
        /// </summary>
        public Page()
        {
            PageTimings = new PageTimings();
        }

        /// <summary>
        /// Date and time stamp for the beginning of the page load.
        /// </summary>
        [JsonProperty("startedDateTime")]
        public DateTime StartedDateTime { get; set; }

        /// <summary>
        /// Unique identifier of a page within the archive. Entries use it to refer the parent page.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Page title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Detailed timing info about page load.
        /// </summary>
        [JsonProperty("pageTimings")]
        public PageTimings PageTimings { get; set; }
    }
}