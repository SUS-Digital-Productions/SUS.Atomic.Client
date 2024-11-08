using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicMarket.Client.Responses.V1.Sales.TemplateSales;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Sales
{
    public class TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
        :
        BaseEndpointGroup,
        ITokenSymbolFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinPriceFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMaxPriceFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISchemaFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ITemplateFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnedAssetsFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOwnerFillterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMatchable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISearchable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IImmutableNameMatchable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMutableNameMatchable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsTransferable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IIsBurnable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IMinterFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IBurnerFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IInitialReceiverFilterable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsBlocklistable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ICollectionsAllowlistable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IPageable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ILimitable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        IOrderable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>,
        ISortable<TemplateSales<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>, TemplateSalesSortType>,
        IExecutable<TemplateSalesResponse<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>>
    {
        internal TemplateSales(string endpoint, string tokenSymbol)
        {
            _endpoint = $"{endpoint}/templates";
            AddQuery("symbol", tokenSymbol);
        }
    }
}
