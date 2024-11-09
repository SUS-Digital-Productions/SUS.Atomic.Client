using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicMarket.Client.Responses.V1.TemplateBuyoffers.SingleTemplateBuyofferLogs
{
    public class SingleTemplateBuyofferLogsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<AtomicLog> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }
}
