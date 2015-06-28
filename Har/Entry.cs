using Newtonsoft.Json;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Represents an exported (tracked) HTTP call.
    /// </summary>
    public class Entry : HarEntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entry"/> class.
        /// </summary>
        public Entry()
        {
            Request = new Request();
            Response = new Response();
            Cache = new Cache();
            Timings = new Timings();
        }

        /// <summary>
        /// Reference to the parent page.
        /// </summary>
        [JsonProperty("pageRef", NullValueHandling = NullValueHandling.Ignore)]
        public string PageRef { get; set; }

        /// <summary>
        /// Date and time stamp of the request start.
        /// </summary>
        [JsonProperty("startedDateTime")]
        public DateTime StartedDateTime { get; set; }

        /// <summary>
        /// Total elapsed time of the request in milliseconds. This is the sum of all timings available in the timings object.
        /// </summary>
        [JsonProperty("time")]
        public int Time { get; set; }

        /// <summary>
        /// Detailed info about the request.
        /// </summary>
        [JsonProperty("request")]
        public Request Request { get; set; }

        /// <summary>
        /// Detailed info about the response.
        /// </summary>
        [JsonProperty("response")]
        public Response Response { get; set; }

        /// <summary>
        /// Info about cache usage.
        /// </summary>
        [JsonProperty("cache")]
        public Cache Cache { get; set; }

        /// <summary>
        /// Detailed timing info about request/response round trip.
        /// </summary>
        [JsonProperty("timings")]
        public Timings Timings { get; set; }

        /// <summary>
        /// IP address of the server that was connected (result of DNS resolution).
        /// </summary>
        [JsonProperty("serverIPAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerIPAddress { get; set; }

        /// <summary>
        /// Unique ID of the parent TCP/IP connection, can be the client or server port number.
        /// </summary>
        /// <remarks>
        /// Note that a port number doesn't have to be unique identifier in cases where the port is shared for more connections. If the port isn't available for the application, any other unique connection ID can be used instead (e.g. connection index). Leave out this field if the application doesn't support this info.
        /// </remarks>
        [JsonProperty("connection", NullValueHandling = NullValueHandling.Ignore)]
        public string Connection { get; set; }
    }
}