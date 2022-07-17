using System;

namespace prototype_design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { FirstName = "Alper", LastName = "Tasci", City = "Nevsehir", Id = 1 };

            Customer customer2 = (Customer)customer.Clone();
            customer2.FirstName = "İnci";
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);
        }
    }
}
