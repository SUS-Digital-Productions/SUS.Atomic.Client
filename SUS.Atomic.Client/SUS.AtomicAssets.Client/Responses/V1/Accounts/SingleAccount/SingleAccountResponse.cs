using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Accounts.SingleAccount
{
    public class SingleAccountResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<Data> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data
    {
        [JsonProperty("collections")]
        public List<CollectionWrapper> Collections { get; set; }

        [JsonProperty("schemas")]
        public List<SchemaWrapper> Schemas { get; set; }
    }

    public class CollectionWrapper
    {
        [JsonProperty("collection")]
        public Collection Collection { get; set; }

        [JsonProperty("assets")]
        public string Assets { get; set; }
    }

    public class Collection : AtomicCollection
    {
        [JsonProperty("contact")]
        public string Contract { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

    }

    public class SchemaWrapper
    {
        [JsonProperty("schema")]
        public Schema Schema { get; set; }

        [JsonProperty("assets")]
        public string Assets { get; set; }
    }

    public class Schema : AtomicSchema
    {

    }



}