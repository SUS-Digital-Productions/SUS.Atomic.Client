using SUS.AtomicAssets.Client.Interfaces;
using System;
using System.Collections.Generic;
namespace SUS.AtomicAssets.Client.EndpointGroups
{
    public class BaseEndpointGroup : IQueryable
    {
        protected string _endpoint;
        protected Dictionary<string, string> queryPairs = new Dictionary<string, string>();

        public void AddMultiArgQuery(string name, List<string> values)
        {
            string value = string.Join(",", values);
            AddQuery(name, value);
        }

        public void AddQuery(string name, string value)
        {
            queryPairs.Add(name, value);
        }
        public string GetURI()
        {
            string query = string.Empty;
            query = "?";
            foreach (var pair in queryPairs)
            {
                query += $"{pair.Key}={pair.Value}&";
            }
            query = query.Remove(query.Length - 1);
            if (string.IsNullOrEmpty(query))
                return _endpoint;
            var endpoint = _endpoint + query;
            Console.WriteLine(endpoint);
            return endpoint;
        }
    }
}