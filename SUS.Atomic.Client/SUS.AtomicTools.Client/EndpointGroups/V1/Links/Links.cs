namespace SUS.AtomicTools.Client.EndpointGroups.V1.Links
{
    public class Links
    {
        private readonly string _endpoint;

        internal Links(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/links";
        }

        public AllLinks Get()
        {
            return new AllLinks(_endpoint);
        }

        public SingleLink Get(long linkId)
        {
            return new SingleLink(_endpoint, linkId);
        }

        public SingleLinkLogs GetLogs(long linkId)
        {
            return new SingleLinkLogs(_endpoint, linkId);
        }
    }
}
