﻿using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicMarket.Client.Responses.V1.Stats.AllSalesStats
{
    public class AllSalesStatsResponse
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
        public Result Result { get; set; }
    }

    public class Result
    {
        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("sales")]
        public string Sales { get; set; }
    }
}
