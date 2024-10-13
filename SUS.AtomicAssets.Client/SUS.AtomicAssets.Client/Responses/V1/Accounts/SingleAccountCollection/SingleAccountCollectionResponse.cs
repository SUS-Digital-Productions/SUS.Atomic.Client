using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Accounts.SingleAccountCollection
{
    public class SingleAccountCollectionResponse
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
        [JsonProperty("templates")]
        public List<Template> Templates { get; set; }

        [JsonProperty("schemas")]
        public List<Schema> Schemas { get; set; }
    }

    public class Template
    {
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("assets")]
        public string Assets { get; set; }
    }

    public class Schema
    {
        [JsonProperty("schema_name")]
        public string SchemaName { get; set; }

        [JsonProperty("assets")]
        public string Assets { get; set; }
    }

}
