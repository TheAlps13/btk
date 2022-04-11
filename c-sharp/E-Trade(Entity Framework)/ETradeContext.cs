using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade_Entity_Framework_
{
    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
