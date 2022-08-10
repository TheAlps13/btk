namespace strategy_design_method
{
    internal partial class Program
    {
        public class CustomerManager
        {
            public CreditCalculatorBase CreditCalculatorBase { get; set; }
            public void CalculateCredit()
            {
                CreditCalculatorBase.Calculate();
            }
        }
    }
}
