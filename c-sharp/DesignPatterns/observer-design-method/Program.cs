using System;

namespace observer_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            Observer employeeObserver = new EmployeeObserver();
            Observer vipObserver = new VipObserver();

            productManager.Attach(vipObserver);
            productManager.Attach(employeeObserver);
            productManager.UpdatePrice();

            Console.WriteLine("After vipCustomer detach;");
            productManager.Detach(vipObserver);
            productManager.UpdatePrice();
        }
    }
}
