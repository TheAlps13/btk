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

    }
}
