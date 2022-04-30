using System;

namespace stock_control_example_using_events_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product hdd = new Product(50);
            hdd.ProductName = "Hard Disk";

            Product cpu =  new Product(50);
            cpu.ProductName = "CPU";
            cpu.StockControlEvent += CpuStockControlEvent;

            do
            {
                hdd.Sell(10);
                cpu.Sell(10);
            }
            while (Console.ReadLine() != "0");
        }

        private static void CpuStockControlEvent()
        {
            Console.WriteLine("CPU is running out of stock");
        }
    }
}
