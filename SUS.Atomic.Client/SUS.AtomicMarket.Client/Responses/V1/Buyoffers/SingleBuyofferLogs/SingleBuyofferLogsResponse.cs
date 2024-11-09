﻿using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Buyoffers.SingleBuyofferLogs
{
    public class SingleBuyofferLogsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<AtomicLog> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }
}