using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Collections
{
    public class GenericSingleCollection<CollectionData> : AtomicCollection
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("data")]
        public CollectionData CollectionInformation { get; set; }
    }
}
