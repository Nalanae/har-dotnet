using Newtonsoft.Json;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Represents an HTTP response.
    /// </summary>
    public class Response : MessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Response"/> class.
        /// </summary>
        public Response()
        {
            Content = new Content();
        }

        /// <summary>
        /// Response status.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Response status description.
        /// </summary>
        [JsonProperty("statusText")]
        public string StatusText { get; set; }

        /// <summary>
        /// Details about the response body.
        /// </summary>
        [JsonProperty("content")]
        public Content Content { get; set; }

        /// <summary>
        /// Redirection target URL from the Location response header.
        /// </summary>
        [JsonProperty("redirectURL")]
        public Uri RedirectUrl { get; set; }
    }
}