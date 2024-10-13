using SUS.AtomicAssets.Client.Interfaces;
using SUS.AtomicAssets.Client.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace SUS.AtomicAssets.Client
{
    public static class LimitableExtensionMethods
    {
        public static Type Limit<Type>(this ILimitable<Type> limitable, int limit)
        {
            limitable.AddQuery("limit", limit.ToString());
            return (Type)limitable;
        }
    }
    public static class OrderableExtensionMethods
    {
        public static Type Order<Type>(this IOrderable<Type> orderable, bool ascending = true)
        {
            if (ascending)
                orderable.AddQuery("order", "asc");
            else
                orderable.AddQuery("order", "desc");
            return (Type)orderable;
        }
    }
    public static class ExecutableExtensionMethods
    {
        public static async Task<Response> Execute<Response>(this IExecutable<Response> executable, IHttpClientFactory factory)
        {
            var client = factory.CreateClient();
            var response = await client.GetAsync(executable.GetURI());
            Response result = await response.Content.ReadAsAsync<Response>();
            return result;
        }
        public static async Task<Response> Execute<Response>(this IExecutable<Response> executable)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(executable.GetURI());
            if (response.IsSuccessStatusCode)
            {
                Response result = await response.Content.ReadAsAsync<Response>();
                return result;
            }
            ErrorResponse errorResponse = await response.Content.ReadAsAsync<ErrorResponse>();
            throw new Exception(errorResponse.Message);
        }
    }
    public static class PageableExtensionMethods
    {
        public static Type Page<Type>(this IPageable<Type> pageable, int page)
        {
            pageable.AddQuery("page", page.ToString());
            return (Type)pageable;
        }
    }
    public static class SchemaFilterableExtensionMethods
    {
        public static Type Schema<Type>(this ISchemaFilterable<Type> schemable, string schema)
        {
            schemable.AddQuery("schema_name", schema);
            return (Type)schemable;
        }
    }
    public static class CollectionFilterableExtensionMethods
    {
        public static Type Collection<Type>(this ICollectionFilterable<Type> collectionFilterable, string collection)
        {
            collectionFilterable.AddQuery("collection_name", collection);
            return (Type)collectionFilterable;
        }
    }

    public static class OwnerMatchableExtensionMethods
    {
        public static Type OwnerMatch<Type>(this IOwnerMatchable<Type> ownerMatchable, string ownerMatch)
        {
            ownerMatchable.AddQuery("match_owner", ownerMatch);
            return (Type)ownerMatchable;
        }
    }

    public static class TemplateFilterableExtensionMethods
    {
        public static Type Template<Type>(this ITemplateFilterable<Type> templateFilterable, long template)
        {
            templateFilterable.AddQuery("template_id", template.ToString());
            return (Type)templateFilterable;
        }
    }

    public static class BurnedAssetsFilterableExtensionMethods
    {
        public static Type Burned<Type>(this IBurnedAssetsFilterable<Type> burnedAssetsFilterable, bool burned)
        {
            burnedAssetsFilterable.AddQuery("burned", burned.ToString());
            return (Type)burnedAssetsFilterable;
        }
    }

    public static class AssetOfferFilterableExtensionMethods
    {
        public static Type HideOffers<Type>(this IAssetOfferFilterable<Type> assetOfferFilterable, bool hideOffers)
        {
            assetOfferFilterable.AddQuery("hide_offers", hideOffers.ToString());
            return (Type)assetOfferFilterable;
        }
    }

    public static class CollectionBlocklistableExtensionMethods
    {
        public static Type BlocklistCollection<Type>(this ICollectionBlocklistable<Type> collectionBlocklistable, List<string> collections)
        {
            collectionBlocklistable.AddMultiArgQuery("collection_blacklist", collections);
            return (Type)collectionBlocklistable;
        }
    }

    public static class CollectionAllowlistableExtensionMethods
    {
        public static Type AllowlistCollection<Type>(this ICollectionAllowlistable<Type> collectionAllowlistable, List<string> collections)
        {
            collectionAllowlistable.AddMultiArgQuery("collection_whitelist", collections);
            return (Type)collectionAllowlistable;
        }
    }

    public static class OwnerFilterableExtensionMethods
    {
        public static Type Owner<Type>(this IOwnerFilterable<Type> ownerFilterable, List<string> owners)
        {
            ownerFilterable.AddMultiArgQuery("owner", owners);
            return (Type)ownerFilterable;
        }
    }

    public static class IdFilterableExtensionMethods
    {
        public static Type Id<Type>(this IIdFilterable<Type> idFilterable, List<string> ids)
        {
            idFilterable.AddMultiArgQuery("ids", ids);
            return (Type)idFilterable;
        }
    }

    public static class LowerBoundableExtensionMethods
    {
        public static Type LowerBound<Type>(this ILowerBoundable<Type> lowerBoundable, long lowerBound)
        {
            lowerBoundable.AddQuery("lower_bound", lowerBound.ToString());
            return (Type)lowerBoundable;
        }
    }

    public static class UpperBoundableExtensionMethods
    {
        public static Type UpperBound<Type>(this IUpperBoundable<Type> upperBoundable, long upperBound)
        {
            upperBoundable.AddQuery("upper_bound", upperBound.ToString());
            return (Type)upperBoundable;
        }
    }

    public static class BurnedByAccountFilterableMethods
    {
        public static Type BurnedByAccount<Type>(this IBurnedByAccountFilterable<Type> burnedByAccountFilterable, List<string> accounts)
        {
            burnedByAccountFilterable.AddMultiArgQuery("burned_by_account", accounts);
            return (Type)burnedByAccountFilterable;
        }
    }

}