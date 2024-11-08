using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicBid
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }

        [JsonProperty("txid")]
        public string TxId { get; set; }
    }
}
