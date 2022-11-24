﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Entity
{

    public enum OrderState
    {
        Cancelled,
        Pending,
        Payed,
        Terminated
    }
    public class Order : AbstractEntity
    {

        public string OrderName { get; set; } = string.Empty;

        public List<Product> Products = new List<Product>();

        public List<Menu> Menus = new List<Menu>();


        public OrderState MenuState { get; set; } = OrderState.Pending;
   
    }
}
