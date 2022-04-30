using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_control_example_using_events_
{
    
    public class Product
    {
        private int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public delegate void StockControl();
        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int StockAmount 
        {
            get { return _stock; }
            set 
            {
                _stock = value;
                if(_stock < 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            } 
        }
        public void Sell(int amount)
        {
           StockAmount -= amount;
            Console.WriteLine($"{ProductName} Stock Amount{StockAmount}");
        }
    }
}
