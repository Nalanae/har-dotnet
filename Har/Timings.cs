using Newtonsoft.Json;

namespace HttpArchive
{
    /// <summary>
    /// Represents timing data about the HTTP call.
    /// </summary>
    public class Timings : HarEntityBase
    {
        /// <summary>
        /// Time spent in a queue waiting for a network connection.
        /// </summary>
        [JsonProperty("blocked", NullValueHandling = NullValueHandling.Ignore)]
        public int? Blocked { get; set; }

        /// <summary>
        /// DNS resolution time. The time required to resolve a host name.
        /// </summary>
        [JsonProperty("dns", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dns { get; set; }

        /// <summary>
        /// Time required to create TCP connection.
        /// </summary>
        [JsonProperty("connect", NullValueHandling = NullValueHandling.Ignore)]
        public int? Connect { get; set; }

        /// <summary>
        /// Time required to send HTTP request to the server.
        /// </summary>
        [JsonProperty("send")]
        public int Send { get; set; }

        /// <summary>
        /// Waiting for a response from the server.
        /// </summary>
        [JsonProperty("wait")]
        public int Wait { get; set; }

        /// <summary>
        /// Time required to read entire response from the server (or cache).
        /// </summary>
        [JsonProperty("receive")]
        public int Receive { get; set; }

        /// <summary>
        /// Time required for SSL/TLS negotiation.
        /// </summary>
        /// <remarks>
        /// If this field is defined then the time is also included in the connect field (to ensure backward compatibility with HAR 1.1).
        /// </remarks>
        [JsonProperty("ssl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ssl { get; set; }
    }
}