using System;

namespace composite_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Name = "Alper",
                LastName = "Tasci"
            };
            Employee employee2 = new Employee
            {
                Name = "Bahri",
                LastName = "Karabal"
            };
            Employee employee3 = new Employee
            {
                Name = "Mehmut",
                LastName = "Tuncer"
            };
            Employee employee4 = new Employee
            {
                Name = "Süleyman",
                LastName = "Bilik"
            };
            employee1.AddSubordinate(employee2);
            employee1.AddSubordinate(employee3);
            employee2.AddSubordinate(employee4);
            employee2.AddSubordinate(employee3);


            Contractor contractor1 = new Contractor
            {
                Name = "Abuzer",
                LastName = "Yıkıcı"
            };

            employee2.AddSubordinate(contractor1);

            foreach(Employee subordinate in employee1)
            {
                Console.WriteLine($"{subordinate.Name} is subordinate of {employee1.Name}");
                foreach(IPerson verySubordinate in subordinate)
                    Console.WriteLine($"{verySubordinate.Name} is subordinate of {subordinate.Name}");
            }


        }
    }
}
