using Newtonsoft.Json;
using System.Collections.Generic;

namespace HttpArchive
{
    /// <summary>
    /// Represents the base of an HTTP message (request/response).
    /// </summary>
    public abstract class MessageBase : HarEntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBase"/> class.
        /// </summary>
        protected MessageBase()
        {
            Cookies = new List<Cookie>();
            Headers = new List<Parameter>();
            HeaderSize = BodySize = -1;
        }

        /// <summary>
        /// Message HTTP Version.
        /// </summary>
        [JsonProperty("httpVersion")]
        public string HttpVersion { get; set; }

        /// <summary>
        /// List of cookie objects.
        /// </summary>
        [JsonProperty("cookies")]
        public IList<Cookie> Cookies { get; set; }

        /// <summary>
        /// List of header objects.
        /// </summary>
        [JsonProperty("headers")]
        public IList<Parameter> Headers { get; set; }

        /// <summary>
        /// Total number of bytes from the start of the HTTP request message until (and including) the double CRLF before the body.
        /// </summary>
        [JsonProperty("headersSize")]
        public int HeaderSize { get; set; }

        /// <summary>
        /// Size of the request body (POST data payload) in bytes.
        /// </summary>
        [JsonProperty("bodySize")]
        public int BodySize { get; set; }
    }
}