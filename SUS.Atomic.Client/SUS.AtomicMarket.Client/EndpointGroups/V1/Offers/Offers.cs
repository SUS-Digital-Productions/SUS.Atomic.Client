using SUS.Atomic.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Offers
{
    public class Offers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup
    {
        internal Offers(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/offers";
        }

        public AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get()
        {
            return new AllOffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }

        public SingleOffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get(long offerId)
        {
            return new SingleOffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint, offerId);
        }

        public SingleOfferLogs GetLogs(long offerId)
        {
            return new SingleOfferLogs(_endpoint, offerId);
        }
    }
}
