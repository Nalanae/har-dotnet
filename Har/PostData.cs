using Newtonsoft.Json;
using System.Collections.Generic;

namespace HttpArchive
{
    /// <summary>
    /// Represents the data posted to the server in an HTTP POST request.
    /// </summary>
    public class PostData : HarEntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostData"/> class.
        /// </summary>
        public PostData()
        {
            Params = new List<PostParameter>();
        }

        /// <summary>
        /// Mime type of posted data.
        /// </summary>
        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        /// List of posted parameters (in case of URL encoded parameters).
        /// </summary>
        [JsonProperty("params")]
        public IList<PostParameter> Params { get; set; }

        /// <summary>
        /// Plain text posted data.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}