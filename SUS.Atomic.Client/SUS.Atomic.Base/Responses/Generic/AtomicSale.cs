using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicSale
    {
        [JsonProperty("market_contract")]
        public string MarketContract { get; set; }

        [JsonProperty("sale_id")]
        public string SaleId { get; set; }
    }
}
