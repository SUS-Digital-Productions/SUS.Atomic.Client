using Newtonsoft.Json;

namespace SUS.Atomic.Base.Responses.Generic
{
    public class AtomicPair
    {
        [JsonProperty("listing_symbol")]
        public string ListingSymbol { get; set; }

        [JsonProperty("settlement_symbol")]
        public string SettlementSymbol { get; set; }

        [JsonProperty("delphi_pair_name")]
        public string DelphiPairName { get; set; }

        [JsonProperty("invert_delphi_pair")]
        public string InvertDelphiPair { get; set; }
    }
}

