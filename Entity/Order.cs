﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Entity
{
    public class Order
    {

        List<Product> products = null;

        Order()
        {
            this.products = new List<Product>();
        }
    }
}
