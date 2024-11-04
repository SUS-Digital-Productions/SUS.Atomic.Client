using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Templates.AllTemplates;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Templates
{
    public class AllTemplates<TemplateImmutableData>
        :
        BaseEndpointGroup,
        ICollectionFilterable<AllTemplates<TemplateImmutableData>>,
        ISchemaFilterable<AllTemplates<TemplateImmutableData>>,
        IIssuedSupplyFilterable<AllTemplates<TemplateImmutableData>>,
        IMinIssuedSupplyFilterable<AllTemplates<TemplateImmutableData>>,
        IMaxIssuedSupplyFilterable<AllTemplates<TemplateImmutableData>>,
        IMaxSupplyFilterable<AllTemplates<TemplateImmutableData>>,
        IIsBurnable<AllTemplates<TemplateImmutableData>>,
        IIsTransferable<AllTemplates<TemplateImmutableData>>,
        IAuthorizedAccountFilterable<AllTemplates<TemplateImmutableData>>,
        IMatchable<AllTemplates<TemplateImmutableData>>,
        ICollectionBlocklistable<AllTemplates<TemplateImmutableData>>,
        ICollectionAllowlistable<AllTemplates<TemplateImmutableData>>,
        ITemplatesFilterable<AllTemplates<TemplateImmutableData>>,
        IIdsFilterable<AllTemplates<TemplateImmutableData>>,
        ILowerBoundable<AllTemplates<TemplateImmutableData>>,
        IUpperBoundable<AllTemplates<TemplateImmutableData>>,
        IBeforeFilterable<AllTemplates<TemplateImmutableData>>,
        IAfterFilterable<AllTemplates<TemplateImmutableData>>,
        IPageable<AllTemplates<TemplateImmutableData>>,
        ILimitable<AllTemplates<TemplateImmutableData>>,
        IOrderable<AllTemplates<TemplateImmutableData>>,
        ISortable<AllTemplates<TemplateImmutableData>, AllTemplatesSortTypes>,
        IExecutable<AllTemplatesResponse<TemplateImmutableData>>
    {
        internal AllTemplates(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
