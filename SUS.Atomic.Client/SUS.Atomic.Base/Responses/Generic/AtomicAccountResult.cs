using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicAccountResult
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("buy_volume")]
        public string BuyVolume { get; set; }

        [JsonProperty("sell_volume")]
        public string SellVolume { get; set; }
    }
}
