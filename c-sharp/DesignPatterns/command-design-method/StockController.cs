using System.Collections.Generic;

namespace command_design_method
{
    public class StockController
    {
        private List<IOrder> _orderList = new List<IOrder>();

        public void AddOrder(IOrder order)
        {
            _orderList.Add(order);
        }

        public void RemoveOrder(IOrder order)
        {
            _orderList.Remove(order);
        }

        public void Execute()
        {
            foreach (IOrder order in _orderList)
                order.Execute();

            _orderList.Clear();
        }
    }
}
