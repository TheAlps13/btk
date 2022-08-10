using System;

namespace observer_design_method
{
    public class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to employees, prices updated !");
        }


    }
}
