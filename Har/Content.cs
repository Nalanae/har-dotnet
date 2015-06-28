using Newtonsoft.Json;

namespace HttpArchive
{
    /// <summary>
    /// Represents the content of an HTTP response.
    /// </summary>
    public class Content : HarEntityBase
    {
        /// <summary>
        /// Length of the returned content in bytes.
        /// </summary>
        /// <remarks>
        /// Should be equal to <see cref="MessageBase.BodySize"/> if there is no compression and bigger when the content has been compressed.
        /// </remarks>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// Number of bytes saved with compression.
        /// </summary>
        [JsonProperty("compression", NullValueHandling = NullValueHandling.Ignore)]
        public int? Compression { get; set; }

        /// <summary>
        /// MIME type of the response text (value of the Content-Type response header). The charset attribute of the MIME type is included (if available).
        /// </summary>
        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        /// Response body sent from the server or loaded from the browser cache.
        /// </summary>
        /// <remarks>
        /// This field is populated with textual content only. The text field is either HTTP decoded text or a encoded (e.g. "base64") representation of the response body.
        /// </remarks>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Encoding used for response text field e.g "base64".
        /// </summary>
        /// <remarks>
        /// Leave out this field if the text field is HTTP decoded (decompressed &amp; unchunked), than trans-coded from its original character set into UTF-8.
        /// </remarks>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }
    }
}