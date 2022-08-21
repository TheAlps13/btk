using System;

namespace command_design_method
{
    public class StockManager
    {
        public string Name { get; set; } = "Soap";
        public int Quantity { get; set; } = 23;

        public void Buy()
        {
            Console.WriteLine($"Customer bought product {Name}\n{Quantity} qts");
        }

        public void Sell()
        {
            Console.WriteLine($"Customer sold product {Name}\n{Quantity} qts");
        }
    }
}
