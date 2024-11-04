using Newtonsoft.Json;

namespace SUS.AtomicAssets.Client.Responses.V1.Templates.SingleTemplate
{
    public class SingleTemplateResponse<TemplateImmutableData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public GenericSingleTemplate<TemplateImmutableData> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; } 
    }
}
