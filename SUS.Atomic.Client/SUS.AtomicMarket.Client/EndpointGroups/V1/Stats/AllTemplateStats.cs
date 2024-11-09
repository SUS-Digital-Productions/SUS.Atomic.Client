using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Stats.AllTemplateStats;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Stats
{
    public class AllTemplateStats<TemplateImmutableData>
        :
        BaseEndpoint,
        ICollectionFilterable<AllTemplateStats<TemplateImmutableData>>,
        ISchemaFilterable<AllTemplateStats<TemplateImmutableData>>,
        ITemplateFilterable<AllTemplateStats<TemplateImmutableData>>,
        IHideUnlistedTemplates<AllTemplateStats<TemplateImmutableData>>,
        IBeforeFilterable<AllTemplateStats<TemplateImmutableData>>,
        IAfterFilterable<AllTemplateStats<TemplateImmutableData>>,
        IIdsFilterable<AllTemplateStats<TemplateImmutableData>>,
        ILowerBoundable<AllTemplateStats<TemplateImmutableData>>,
        IUpperBoundable<AllTemplateStats<TemplateImmutableData>>,
        IPageable<AllTemplateStats<TemplateImmutableData>>,
        ILimitable<AllTemplateStats<TemplateImmutableData>>,
        IOrderable<AllTemplateStats<TemplateImmutableData>>,
        ISortable<AllTemplateStats<TemplateImmutableData>, AllTemplateStatsSortType>,
        IExecutable<AllTemplateStatsResponse<TemplateImmutableData>>
    {
        internal AllTemplateStats(string endpoint, string symbol, string search)
        {
            _endpoint = $"{endpoint}/templates";
            AddQuery("symbol", symbol);
            AddQuery("search", search);
        }
    }
}
