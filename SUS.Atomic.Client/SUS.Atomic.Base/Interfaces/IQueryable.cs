using System.Collections.Generic;

namespace SUS.Atomic.Base.Interfaces
{
    public interface IQueryable
    {
        void AddQuery(string name, string value);
        string GetURI();
        void AddMultiArgQuery(string name, List<string> values);
    }
}