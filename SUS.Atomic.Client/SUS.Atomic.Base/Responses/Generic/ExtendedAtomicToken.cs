using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class ExtendedAtomicToken : AtomicToken
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }
    }
}
