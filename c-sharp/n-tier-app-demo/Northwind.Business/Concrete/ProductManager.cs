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
<<<<<<< HEAD
            return _efProductDal.GetAll();
=======
            return _efProductDal.GetAllProducts();
>>>>>>> fc74e27c320710ee403aacd1f0b680be84853356
        }

    }
}
