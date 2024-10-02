using System.Collections.Generic;

namespace SUS.AtomicAssets.Client.Interfaces
{
    public interface IQueryable
    {
        void AddQuery(string name, string value);
        string GetURI();

        void AddMultiArgQuery(string name, List<string> values);
    }
}