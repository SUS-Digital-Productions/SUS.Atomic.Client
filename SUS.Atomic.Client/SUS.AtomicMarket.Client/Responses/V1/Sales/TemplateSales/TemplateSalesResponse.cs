﻿using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Sales.TemplateSales
{
    public class TemplateSalesResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<ExtendedAtomicSale<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>> Data { get;set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }
}