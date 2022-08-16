using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_example
{
    public class CustomerManager
    {
        private static CustomerManager _customerManager;
        static object _customerManagerLock = new object();
        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSingleton()
        {
            if (_customerManager == null)
            {
                lock (_customerManagerLock)
                {
                    if (_customerManager == null)
                    {
                        _customerManager = new CustomerManager();
                    }
                }
            }

            return _customerManager;
        }

        public void Save()
        {
            Console.WriteLine("Saved !");
        }
    }
}
