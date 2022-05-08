using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System.Collections.Generic;


namespace Northwind.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();
        public List<Product> GetAllProducts()
        {
            // Business code
          
            return _productDal.GetAllProducts();
        }

    }
}
