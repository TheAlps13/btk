using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFranework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Northwind.DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
