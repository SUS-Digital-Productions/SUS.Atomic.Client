using SUS.AtomicAssets.Client.Interfaces;
using SUS.AtomicAssets.Client.Responses;
using System;
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
    public static class BuildableExtensionMethods
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
    public static class SchemableExtensionMethods
    {
        public static Type Schema<Type>(this ISchemable<Type> schemable, string schema)
        {
            schemable.AddQuery("schema_name", schema);
            return (Type)schemable;
        }
    }
    public static class CollectionableExtensionMethods
    {
        public static Type Collection<Type>(this ICollectionable<Type> collectionable, string collection)
        {
            collectionable.AddQuery("collection_name", collection);
            return (Type)collectionable;
        }
    }
}