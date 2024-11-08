using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicTools.Client.Responses.V1.Links.SingleLink;

namespace SUS.AtomicTools.Client.EndpointGroups.V1.Links
{
    public class SingleLink<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup,
        IExecutable<SingleLinkResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal SingleLink(string endpoint, long linkId)
        {
            _endpoint = $"{endpoint}/{linkId}";
        }
    }
}
