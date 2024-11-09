using SUS.Atomic.Base;

namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Burns
{
    public class Burns
        :
        BaseEndpointGroup
    {
        internal Burns(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/burns";
        }

        public AllBurns Get()
        {
            return new AllBurns(_endpoint);
        }

        public BurnsAccount Get(string account)
        {
            return new BurnsAccount(_endpoint, account);
        }
    }
}
