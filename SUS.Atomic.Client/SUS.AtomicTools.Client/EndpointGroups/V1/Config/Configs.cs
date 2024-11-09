using SUS.Atomic.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicTools.Client.EndpointGroups.V1.Config
{
    public class Configs
        :
        BaseEndpointGroup
    {

        internal Configs(string endpoint)
        {
            _endpoint = $"{endpoint}/v1/config";
        }

        public Config Get()
        {
            return new Config(_endpoint);
        }
    }
}
