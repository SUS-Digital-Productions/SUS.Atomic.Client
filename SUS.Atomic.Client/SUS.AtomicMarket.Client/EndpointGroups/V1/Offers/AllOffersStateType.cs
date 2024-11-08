using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.AtomicMarket.Client.EndpointGroups.V1.Offers
{
    public enum AllOffersStateType
    {
        PENDING = 0,
        INVALID = 1,
        UNKNOWN = 2,
        ACCEPTED = 3,
        DECLINED = 4,
        CANCELLED = 5,
    }
}
