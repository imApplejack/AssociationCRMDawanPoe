using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Persistance
{
    public class OrderRepository : AbstractRepository
    {
        public OrderRepository(string connexionString) : base(connexionString)
        {
        }
    }
}
