using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concrete;

using System.Configuration;

namespace Northwind.DataAccess.Concrete
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["NorthwindContext"].ToString());
        }
        public DbSet<Product> Products { get; set; }
    }
}
