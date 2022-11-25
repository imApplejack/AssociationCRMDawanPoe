using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Persistance
{
    public class ProductRepository : AbstractRepository
    {
        public ProductRepository(string connexionString) : base(connexionString)
        {




        }


        public List<Product> getAll()
        {




            return new List<Product>();
        }

    }
}
