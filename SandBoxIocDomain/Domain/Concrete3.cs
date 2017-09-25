﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxIocDomain.Domain
{
    public class Concrete3 : IShippingType
    {
        public Shipping GetShipping()
        {
            return new Shipping() { ShippingName = "Injected Shipping", SupportPrioroty = true, Rate = 0.99f };
        }
    }
}
