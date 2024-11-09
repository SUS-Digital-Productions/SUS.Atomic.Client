using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Stats.AllSalesStats;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Stats
{
    public class AllSalesStats
        :
        BaseEndpoint,
        ICollectionsBlocklistable<AllSalesStats>,
        ICollectionsAllowlistable<AllSalesStats>,
        IExecutable<AllSalesStatsResponse>
    {
        internal AllSalesStats(string endpoint, string symbol)
        {
            _endpoint = $"{endpoint}/sales";
            AddQuery("symbol", symbol);
        }
    }
}
