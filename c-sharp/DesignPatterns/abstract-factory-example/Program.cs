using System;

namespace abstract_factory_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // ProductManager productManager = new ProductManager(new Factory1());
            ProductManager productManager = new ProductManager(new Factory1());
            productManager.GetAll();
        }
    }
        
}
