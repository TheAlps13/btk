using System;

namespace abstraction_example
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new(new DatabaseLogger());
            manager.Add();
        }
    }
}
