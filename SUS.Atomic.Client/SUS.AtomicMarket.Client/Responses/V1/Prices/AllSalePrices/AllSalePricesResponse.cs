using Newtonsoft.Json;
using SUS.Atomic.Base.Responses.Generic;
using System.Collections.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Prices.AllSalePrices
{
    public class AllSalePricesResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<Data> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data : AtomicToken
    {
        [JsonProperty("sale_id")]
        public string SaleId { get; set; }

        [JsonProperty("auction_id")]
        public string AuctionId { get; set; }

        [JsonProperty("buyoffer_id")]
        public string BuyofferId { get; set; }

        [JsonProperty("template_mint")]
        public string TemplateMint { get; set; }

        [JsonProperty("block_time")]
        public string BlockTime { get; set; }
    }

}
