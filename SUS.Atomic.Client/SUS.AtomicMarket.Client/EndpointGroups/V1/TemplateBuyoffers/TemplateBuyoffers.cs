using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.TemplateBuyoffers
{
    public class TemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>
    {
        private readonly string _endpoint;

        internal TemplateBuyoffers(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/template_buyoffers";
        }

        public AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get()
        {
            return new AllTemplateBuyoffers<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint);
        }

        public SingleTemplateBuyoffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData> Get(long buyofferId)
        {
            return new SingleTemplateBuyoffer<TemplateImmutableData, AssetImmutableData, AssetMutableData, CombinedData>(_endpoint, buyofferId);
        }

        public SingleTemplateBuyofferLogs GetLogs(long buyofferId)
        {
            return new SingleTemplateBuyofferLogs(_endpoint, buyofferId);
        }
    }
}
