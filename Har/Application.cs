using HttpArchive.Utility;
using Newtonsoft.Json;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Represents an application that is used as the browser/creator of the HTTP archive.
    /// </summary>
    public class Application : HarEntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// </summary>
        public Application()
        {
            Version = new Version();
        }

        /// <summary>
        /// Name of the application/browser used to export the log.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Version of the application/browser used to export the log.
        /// </summary>
        [JsonProperty("version")]
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }
    }
}