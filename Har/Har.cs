using Newtonsoft.Json;
using System;
using System.Linq;
using Validation;

namespace HttpArchive
{
    /// <summary>
    /// Entrypoint for HTTP archive (de)serializing.
    /// </summary>
    public class Har
    {
        private static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            Formatting = Formatting.None
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Har"/> class.
        /// </summary>
        public Har()
        {
            Log = new Log();
        }

        /// <summary>
        /// The root object of a HTTP archive.
        /// </summary>
        [JsonProperty("log")]
        public Log Log { get; set; }

        /// <summary>
        /// Deserialize the HTTP archive string.
        /// </summary>
        /// <param name="har">The HTTP archive string.</param>
        /// <returns>The HTTP archive object.</returns>
        public static Har Deserialize(string har)
        {
            return JsonConvert.DeserializeObject<Har>(har, SerializerSettings);
        }

        /// <summary>
        /// Serialize the HTTP archive object.
        /// </summary>
        /// <param name="har">The HTTP archive object.</param>
        /// <returns>The HTTP archive string.</returns>
        /// <exception cref="InvalidOperationException">If the page ids contain duplicates or unknown page ids are referenced from an entry.</exception>
        public static string Serialize(Har har)
        {
            Requires.NotNull(har, nameof(har));

            var countPages = har.Log.Pages.Count();
            var pageIds = har.Log.Pages.Select(p => p.Id).Distinct();
            if (countPages > pageIds.Count())
                throw new InvalidOperationException(Resources.PageIdsNotUnique);
            if (har.Log.Entries.Any(e => !pageIds.Contains(e.PageRef)))
                throw new InvalidOperationException(Resources.EntryPageRefNotFound);

            return JsonConvert.SerializeObject(har, SerializerSettings);
        }
    }
}