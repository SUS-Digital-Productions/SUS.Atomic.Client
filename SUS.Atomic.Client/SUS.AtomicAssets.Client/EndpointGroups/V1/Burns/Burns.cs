namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Burns
{
    public class Burns
    {
        private readonly string _endpoint;

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
