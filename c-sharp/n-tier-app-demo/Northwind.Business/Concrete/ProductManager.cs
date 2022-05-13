using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System.Collections.Generic;


namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _efProductDal;
        public ProductManager(IProductDal productDal)
        {
            _efProductDal = productDal;
        }
        public List<Product> GetAllProducts()
        {
            // Business code
            return _efProductDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
           return _efProductDal.GetAll(p => p.CategoryId == categoryId);
        }
        public List<Product> GetProductsByName(string productName)
        {
            return _efProductDal.GetAll(p => p.ProductName.Contains(productName));
        }
    }
}
