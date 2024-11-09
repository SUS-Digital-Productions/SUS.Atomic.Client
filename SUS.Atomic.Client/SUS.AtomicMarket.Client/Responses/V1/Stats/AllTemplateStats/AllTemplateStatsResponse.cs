using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Stats.AllTemplateStats
{
    public class AllTemplateStatsResponse<TemplateImmutableData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<Data<TemplateImmutableData>> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data<TemplateImmutableData>
    {
        [JsonProperty("symbol")]
        public AtomicToken Symbol { get; set; }

        [JsonProperty("results")]
        public List<Result<TemplateImmutableData>> Results { get; set; }
    }

    public class Result<TemplateImmutableData>
    {
        [JsonProperty("template")]
        public AtomicTemplateResult<TemplateImmutableData> Template { get; set; }

        [JsonProperty("sales")]
        public string Sales { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }
    }
}
