namespace strategy_design_method
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new();
            customerManager.CreditCalculatorBase = new CalculateCreditNew();
            customerManager.CalculateCredit();
        }
    }
}
