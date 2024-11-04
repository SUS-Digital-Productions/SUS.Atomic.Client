namespace SUS.AtomicMarket.Client
{
    public class AtomicMarketClient
    {
        private readonly string _endpoint;

        public AtomicMarketClient(string endpoint)
        {
            _endpoint = $"{endpoint}/atomicmarket";
        }
    }
}
