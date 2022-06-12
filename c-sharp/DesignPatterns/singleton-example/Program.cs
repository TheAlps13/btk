﻿using System;

namespace singleton_design_pattern_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();
        }
    }
}
