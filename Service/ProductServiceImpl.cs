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
        public List<Product> getAllProduct()
        {
           return new List<Product>() { new Product() { Id = 0, Name = "Kebab", Price=1, ProductCategory = ProductCategory.Plat}, new Product() { Id = 0, Name = "Burger", Price = 10 , ProductCategory = ProductCategory.Plat  }, new Product() { Id = 0, Name = "Coca", Price = 10 , ProductCategory = ProductCategory.Boisson } };
        }
    }
}
