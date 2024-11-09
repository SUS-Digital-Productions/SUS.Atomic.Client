﻿using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicMarket.Client.Responses.V1.Stats.SingleCollectionStatsResponse
{
    public class SingleCollectionStatsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data
    {
        [JsonProperty("symbol")]
        public AtomicToken Symbol { get; set; }

        [JsonProperty("results")]
        public List<AtomicCollectionResult> Results { get; set; }
    }
}