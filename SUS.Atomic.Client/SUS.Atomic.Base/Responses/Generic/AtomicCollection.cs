using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.Atomic.Base.Responses.Generic
{
    public abstract class AtomicCollection
    {
        [JsonProperty("collection_name")]
        public string CollectionName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("allow_notify")]
        public bool AllowNotify { get; set; }

        [JsonProperty("authorized_accounts")]
        public List<string> AuthorizedAccounts { get; set; }

        [JsonProperty("notify_accounts")]
        public List<string> NotifiedAccounts { get; set; }

        [JsonProperty("market_fee")]
        public decimal MarketFee { get; set; }

        [JsonProperty("created_at_block")]
        public long CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time")]
        public long CreatedAtTime { get; set; }
    }
}
