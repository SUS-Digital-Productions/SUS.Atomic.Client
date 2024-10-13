using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Burns.BurnsAccount
{
    public class BurnsAccountResponse
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
        public List<Collection> Collections { get; set; }

        [JsonProperty("templates")]
        public List<Template> Templates { get; set; }

        [JsonProperty("assets")]
        public string Assets { get; set; }
    }

    public class Collection
    {
        [JsonProperty("collection_name")]
        public string CollectionName { get; set; }

        [JsonProperty("assets")]
        public string Assets { get; set; }
    }

    public class Template
    {
        [JsonProperty("collection_name")]
        public string ColletionName { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("assets")]
        public string Assets { get; set; }
    }
}
