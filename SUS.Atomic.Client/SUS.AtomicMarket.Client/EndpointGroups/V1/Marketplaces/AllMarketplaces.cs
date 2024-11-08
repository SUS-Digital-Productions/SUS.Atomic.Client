using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Marketplaces.AllMarketplaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Marketplaces
{
    public class AllMarketplaces
        :
        BaseEndpointGroup,
        IExecutable<AllMarketplacesResponse>
    {
        internal AllMarketplaces(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
