namespace command_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockController controller = new StockController();
            StockManager manager = new StockManager();
            SellOrder sellOrder = new SellOrder(manager);
            BuyOrder buyOrder = new BuyOrder(manager);

            controller.AddOrder(sellOrder);
            controller.Execute();
            manager.Quantity = 3;
            manager.Name = "Tea";
            controller.AddOrder(sellOrder);
            controller.Execute();
        }
    }
}
