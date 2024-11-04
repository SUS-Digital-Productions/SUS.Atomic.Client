using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicToken
    {
        [JsonProperty("token_contract")]
        public string Contract { get; set; }

        [JsonProperty("token_precision")]
        public int Precision { get; set; }

        [JsonProperty("token_symbol")]
        public string Symbol { get; set; }  
    }
}
