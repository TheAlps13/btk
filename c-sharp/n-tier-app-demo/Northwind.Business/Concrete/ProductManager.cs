using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilites;
using Northwind.Business.ValidationRules.FluentValidation;
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

        public void AddProduct(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _efProductDal.Add(product);
        }

        public void DeleteProduct(Product product)
        {
                _efProductDal.Delete(product);
        }

        public List<Product> GetAllProducts()
        {
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

        public void UpdateProduct(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _efProductDal.Update(product);
        }
    }
}
