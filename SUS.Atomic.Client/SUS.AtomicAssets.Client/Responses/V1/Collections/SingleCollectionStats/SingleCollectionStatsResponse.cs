﻿using Newtonsoft.Json;

namespace SUS.AtomicAssets.Client.Responses.V1.Collections.SingleCollectionStats
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
        [JsonProperty("assets")]
        public string Assets { get; set; }

        [JsonProperty("burned")]
        public string Burned { get; set; }

        [JsonProperty("templates")]
        public string Templates { get; set; }

        [JsonProperty("schemas")]
        public string Schemas { get; set; }
    }
}
