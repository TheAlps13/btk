namespace command_design_method
{
    public class SellOrder : IOrder
    {
        StockManager _stockManager;

        public SellOrder(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Sell();
        }
    }
}
