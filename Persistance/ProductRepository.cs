using AssociationCRMDawanPoe.Entity;
using SqlKata.Compilers;
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



            var connection = new SqlConnection(this.ConnexionString);

            return new List<Product>();
        }

    }
}
