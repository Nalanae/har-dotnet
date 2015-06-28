using Newtonsoft.Json;

namespace HttpArchive
{
    /// <summary>
    /// Represents the base of every HTTP archive entity.
    /// </summary>
    public abstract class HarEntityBase
    {
        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }
    }
}