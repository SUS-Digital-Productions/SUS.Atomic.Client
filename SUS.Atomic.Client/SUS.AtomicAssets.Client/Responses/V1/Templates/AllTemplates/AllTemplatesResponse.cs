using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Templates.AllTemplates
{
    public class AllTemplatesResponse<TemplateImmutableData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<GenericSingleTemplate<TemplateImmutableData>> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }
}
