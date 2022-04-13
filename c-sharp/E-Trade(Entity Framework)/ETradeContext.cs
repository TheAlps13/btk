using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace E_Trade_Entity_Framework_
{
    public class ETradeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ETradeContext"].ToString());
        }

        public DbSet<Product> Products { get; set; }
    }
}
