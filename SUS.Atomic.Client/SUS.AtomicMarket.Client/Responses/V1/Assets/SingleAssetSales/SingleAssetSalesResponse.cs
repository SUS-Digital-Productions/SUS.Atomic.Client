using Newtonsoft.Json;
using System.Collections.Generic;

namespace SUS.AtomicMarket.Client.Responses.V1.Assets.SingleAssetSales
{
    public class SingleAssetSalesResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<Data> Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }
    }

    public class Data
    {
        [JsonProperty("sale_id")]
        public string SaleId { get; set; }

        [JsonProperty("auction_id")]
        public string AuctionId { get; set; }

        [JsonProperty("buyoffer_id")]
        public string BuyofferId { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("token_symbol")]
        public string TokenSymbol { get; set; }

        [JsonProperty("token_precision")]
        public int TokenPrecision { get; set; }

        [JsonProperty("token_contract")]
        public string TokenContract { get; set; }

        [JsonProperty("seller")]
        public string Seller { get; set; }

        [JsonProperty("buyer")]
        public string Buyer { get; set; }

        [JsonProperty("block_time")]
        public string BlockTime { get; set; }
    }
}
