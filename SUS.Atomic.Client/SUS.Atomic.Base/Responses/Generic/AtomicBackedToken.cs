using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicBackedToken
    {
        [JsonProperty("token_contract")]
        public string TokenContract { get; set; }

        [JsonProperty("token_symbol")]
        public string TokenSymbol { get; set; }

        [JsonProperty("token_precision")]
        public int TokenPrecision { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }
    }
}
