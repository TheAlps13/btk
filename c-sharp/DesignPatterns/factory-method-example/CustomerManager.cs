using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example
{
    public class CustomerManager
    {
        public void Save()
        {
            ILogger logger = LoggerFactory.CreateInstance("Joker");
            logger.Log("Saved !");
        }
    }
}
