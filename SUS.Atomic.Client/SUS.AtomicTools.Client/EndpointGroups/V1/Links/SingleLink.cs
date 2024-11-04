using SUS.Atomic.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicTools.Client.EndpointGroups.V1.Links
{
    public class SingleLink
        :
        BaseEndpointGroup
    {
        internal SingleLink(string endpoint, long linkId)
        {
            _endpoint = $"{endpoint}/{linkId}";
        }
    }
}
