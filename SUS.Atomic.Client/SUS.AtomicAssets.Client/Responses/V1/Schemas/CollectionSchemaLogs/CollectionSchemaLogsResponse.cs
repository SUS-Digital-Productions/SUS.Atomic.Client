﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Dynamic;

namespace SUS.AtomicAssets.Client.Responses.V1.Schemas.CollectionSchemaLogs
{
    public class CollectionSchemaLogsResponse
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
        [JsonProperty("log_id")]
        public string LogId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data")]
        public object DataObject { get; set; }

        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }
    }
}