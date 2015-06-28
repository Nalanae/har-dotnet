using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HttpArchive
{
    /// <summary>
    /// Represents an HTTP request.
    /// </summary>
    public class Request : MessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Request"/> class.
        /// </summary>
        public Request()
        {
            QueryString = new List<Parameter>();
            PostData = new PostData();
        }

        /// <summary>
        /// Request method (GET, POST, ...).
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// Absolute URL of the request (fragments are not included).
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// List of query parameter objects.
        /// </summary>
        [JsonProperty("queryString")]
        public IList<Parameter> QueryString { get; set; }

        /// <summary>
        /// Posted data info.
        /// </summary>
        [JsonProperty("postData", NullValueHandling = NullValueHandling.Ignore)]
        public PostData PostData { get; set; }
    }
}