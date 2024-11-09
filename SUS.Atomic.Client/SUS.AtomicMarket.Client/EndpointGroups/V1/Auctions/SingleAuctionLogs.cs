using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Auctions.SingleAuctionLogs;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Auctions
{
    public class SingleAuctionLogs
        :
        BaseEndpoint,
        IExecutable<SingleAuctionLogsResponse>
    {
        internal SingleAuctionLogs(string endpoint, long auctionId)
        {
            _endpoint = $"{endpoint}/{auctionId}/logs";
        }
    }
}
