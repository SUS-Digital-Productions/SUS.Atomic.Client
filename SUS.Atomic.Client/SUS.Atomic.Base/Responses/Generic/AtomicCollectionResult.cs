using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicCollectionResult : AtomicCollection
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("data")]
        public dynamic Data { get; set; }

        [JsonProperty("listings")]
        public string Listings { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("Sales")]
        public string Sales { get; set; }
    }
}
