using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new();


            manager.Add(new Customer
            {
                Id = 1,
                FirstName = "Alper",
                LastName = "Tasci",
                Address = "Cigkofte adalari"
            });

            manager.Add(new Student
            {
                 Id = 1,
                FirstName = "İmren",
                LastName = "Tasci",
                
            });
        }
    }
}
