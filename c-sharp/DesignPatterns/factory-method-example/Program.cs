using System;

namespace factory_method_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
        }
    }
}
