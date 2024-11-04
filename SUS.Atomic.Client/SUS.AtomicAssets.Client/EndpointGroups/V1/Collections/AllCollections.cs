using SUS.Atomic.Base;
using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses.V1.Collections.AllCollections;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Collections
{
    public class AllCollections<CollectionData>
        :
        BaseEndpointGroup,
        IAuthorFilterable<AllCollections<CollectionData>>,
        IMatchable<AllCollections<CollectionData>>,
        IAuthorizedAccountFilterable<AllCollections<CollectionData>>,
        INotifyAccountFilterable<AllCollections<CollectionData>>,
        ICollectionBlocklistable<AllCollections<CollectionData>>,
        ICollectionAllowlistable<AllCollections<CollectionData>>,
        ICollectionsFilterable<AllCollections<CollectionData>>,
        IIdsFilterable<AllCollections<CollectionData>>,
        ILowerBoundable<AllCollections<CollectionData>>,
        IUpperBoundable<AllCollections<CollectionData>>,
        IBeforeFilterable<AllCollections<CollectionData>>,
        IAfterFilterable<AllCollections<CollectionData>>,
        IPageable<AllCollections<CollectionData>>,
        ILimitable<AllCollections<CollectionData>>,
        IOrderable<AllCollections<CollectionData>>,
        ISortable<AllCollections<CollectionData>, AllCollectionSortType>,
        IExecutable<AllCollectionsResponse<CollectionData>>
    {
        internal AllCollections(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
