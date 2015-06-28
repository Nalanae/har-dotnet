using HttpArchive.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HttpArchive
{
    /// <summary>
    /// Represents the root object of an HTTP archive.
    /// </summary>
    public class Log : HarEntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        public Log()
        {
            Version = new Version("1.2");
            Creator = new Application();
            Browser = new Application();
            Pages = new List<Page>();
            Entries = new List<Entry>();
        }

        /// <summary>
        /// Version number of the format. If empty, string "1.1" is assumed by default.
        /// </summary>
        [JsonProperty("version")]
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }

        /// <summary>
        /// Name and version info of the log creator application.
        /// </summary>
        [JsonProperty("creator")]
        public Application Creator { get; set; }

        /// <summary>
        /// Name and version info of used browser.
        /// </summary>
        [JsonProperty("browser", NullValueHandling = NullValueHandling.Ignore)]
        public Application Browser { get; set; }

        /// <summary>
        /// List of all exported (tracked) pages. Leave out this field if the application does not support grouping by pages.
        /// </summary>
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Page> Pages { get; set; }

        /// <summary>
        /// List of all exported (tracked) requests.
        /// </summary>
        [JsonProperty("entries")]
        public IList<Entry> Entries { get; set; }
    }
}