using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicTemplateBuyoffer
    {
        [JsonProperty("market_contract")]
        public string MarketContract { get; set; }

        [JsonProperty("buyoffer_id")]
        public string BuyofferId { get; set; }

        [JsonProperty("token_symbol")]
        public string TokenSymbol { get; set; }
    }
}
