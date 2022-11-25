using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public interface IProductService
    {
        List<Product> FindByName(string name);
        List<Product> FindByCategory(string Category);
        List<Product> GetAll();

        public List<Product> getAllProduct();
        public List<string> GetAllCategory();

    }
}
