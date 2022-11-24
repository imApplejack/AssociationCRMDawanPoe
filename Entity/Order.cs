using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Entity
{

    public enum MenuState
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

        public MenuState MenuState { get; set; } = MenuState.Pending;
   
    }
}
