using SUS.Atomic.Base;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class Accounts
        :
        BaseEndpointGroup
    {
        internal Accounts(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/accounts";
        }
        public AllAccounts Get()
        {
            return new AllAccounts(_endpoint);
        }
        public SingleAccount Get(string account)
        {
            return new SingleAccount(_endpoint, account);
        }

        public SingleAccountCollection Get(string account, string collection)
        {
            return new SingleAccountCollection(_endpoint, account, collection);
        }
    }
}