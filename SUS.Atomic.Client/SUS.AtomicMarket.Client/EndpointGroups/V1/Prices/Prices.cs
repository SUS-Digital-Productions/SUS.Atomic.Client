using SUS.Atomic.Base;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Prices
{
    public class Prices
        :
        BaseEndpointGroup
    {
        internal Prices(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/prices";
        }

        public AllDaySalePrices GetDayPrices()
        {
            return new AllDaySalePrices(_endpoint);
        }

        public AllAssetPrices GetAssetPrices()
        {
            return new AllAssetPrices(_endpoint);
        }

        public SingleAccountInventoryPrices GetAccountInventoryPrice(string account)
        {
            return new SingleAccountInventoryPrices(_endpoint, account);
        }
    }
}
