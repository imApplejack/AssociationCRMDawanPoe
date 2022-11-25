using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public class ProductServiceImpl : IProductService
    {

        public List<Product> FindByCategory(string Category)
        {
            List<Product> products = new List<Product>();
            foreach (Product item in this.GetAll())
            {
                if (item.ProductCategory.ToString() == Category)
                {
                    products.Add(item);
                }
            }
            return products;
        }

        public List<Product> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
