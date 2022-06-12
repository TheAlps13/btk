using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_design_pattern_example
{
    public class CustomerManager
    {
        private static CustomerManager _customerManager;
        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSingleton()
        {
           return _customerManager ??= new CustomerManager();
        }

        public void Save()
        {
            Console.WriteLine("Saved !");
        }
    }
}
