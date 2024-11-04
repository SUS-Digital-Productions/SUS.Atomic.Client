using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Responses.V1.Assets.SingleAssetLogs
{
    public class SingleAssetLogsResponse
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
        public object LogData { get; set; }

        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }
    }
}
