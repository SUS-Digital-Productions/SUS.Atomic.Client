using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.TemplateBuyoffers.SingleTemplateBuyoffer;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.TemplateBuyoffers
{
    public class SingleTemplateBuyoffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpoint,
        IExecutable<SingleTemplateBuyofferResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal SingleTemplateBuyoffer(string endpoint, long buyofferId)
        {
            _endpoint = $"{endpoint}/{buyofferId}";
        }
    }
}
