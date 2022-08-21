namespace command_design_method
{
    public class BuyOrder : IOrder
    {
        StockManager _stockManager;
        public BuyOrder(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Buy();
        }
    }
}
