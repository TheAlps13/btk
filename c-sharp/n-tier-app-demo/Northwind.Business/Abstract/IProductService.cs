using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByName(string productName);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
    }
}
