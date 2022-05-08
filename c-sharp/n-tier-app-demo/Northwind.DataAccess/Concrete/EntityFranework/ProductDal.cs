using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;


namespace Northwind.DataAccess.Concrete
{
    public class ProductDal
    {
        public List<Product> GetAllProducts()
        {
            using(NorthwindContext context = new NorthwindContext())
                return context.Products.ToList();
            
        }
        public Product GetProduct(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
                return context.Products.SingleOrDefault(p => p.ProductId == id);
        }
        public void AddProduct(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void UpdateProduct(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Update(product);
                context.SaveChanges(true);
            }
        }
        public void DeleteProduct(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
