using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace E_Trade_Entity_Framework_
{
    public class ProductDal
    {
        public List<Product> GetAllProducts()
        {
            using (ETradeContext eTradeContext = new ETradeContext())
                return eTradeContext.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
                return eTradeContext.Products.FirstOrDefault(p => p.Id == id);
        }
        public List<Product> GetProductByName(string name)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
                return eTradeContext.Products.Where(product => product.Name.Contains(name)).ToList();
        }
        public List<Product> GetProductByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
                return eTradeContext.Products.Where(product => product.UnitPrice >= min && product.UnitPrice <= max).ToList();
        }
        
        public void AddProduct(Product product)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                var productEntity = eTradeContext.Entry(product);
                productEntity.State = EntityState.Added;
                eTradeContext.SaveChanges();
            }
        }
        public void UpdateProduct(Product product)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                var entity = eTradeContext.Entry(product);
                entity.State = EntityState.Modified;
                eTradeContext.SaveChanges();
            }
        }
        public void DeleteProduct(Product product)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                var entity = eTradeContext.Entry(product);
                entity.State = EntityState.Deleted;
                eTradeContext.SaveChanges();
            }
        }
    }
}
