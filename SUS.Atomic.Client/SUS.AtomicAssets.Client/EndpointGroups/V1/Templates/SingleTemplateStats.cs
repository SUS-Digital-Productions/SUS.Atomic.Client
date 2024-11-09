using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Templates.SingleTemplateStats;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Templates
{
    public class SingleTemplateStats
        :
        BaseEndpoint,
        IExecutable<SingleTemplateStatsResponse>
    {
        internal SingleTemplateStats(string endpoint, string collectionName, long templateId)
        {
            _endpoint = $"{endpoint}/{collectionName}/{templateId}/stats";
        }
    }
}
