using System;

namespace strategy_design_method
{
    internal partial class Program
    {
        public class CalculateCreditNew : CreditCalculatorBase
        {
            public override void Calculate()
            {
                Console.WriteLine("Credit calculated for new customer");
            }
        }
    }
}
