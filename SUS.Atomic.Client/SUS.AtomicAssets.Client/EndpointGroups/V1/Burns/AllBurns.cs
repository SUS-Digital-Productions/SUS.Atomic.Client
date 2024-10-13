using SUS.AtomicAssets.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Burns
{
    public class AllBurns
        :
        BaseEndpointGroup,
        IOwnerMatchable<AllBurns>,
        ICollectionFilterable<AllBurns>,
        ISchemaFilterable<AllBurns>,
        ITemplateFilterable<AllBurns>,
        IBurnedAssetsFilterable<AllBurns>,
        ICollectionBlocklistable<AllBurns>,
        ICollectionAllowlistable<AllBurns>,
        IBurnedByAccountFilterable<AllBurns>,
        IIdFilterable<AllBurns>,
        ILowerBoundable<AllBurns>,
        IUpperBoundable<AllBurns>,
        IPageable<AllBurns>,
        ILimitable<AllBurns>,
        IOrderable<AllBurns>,
        IExecutable<AllBurns>
    {
        internal AllBurns(string endpoint)
        {
            _endpoint = endpoint;
        }
    }
}
