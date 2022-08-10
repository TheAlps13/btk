using System;

namespace observer_design_method
{
    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to customers, prices updated !");
        }


    }
}
