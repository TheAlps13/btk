using System;

namespace observer_design_method
{
    public class VipObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to vip customers, prices updated !");
        }


    }
}
