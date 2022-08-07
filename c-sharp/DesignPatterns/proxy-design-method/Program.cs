using System;
using System.Threading;

namespace proxy_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime;

            //Test without proxy
            Console.WriteLine("Without proxy design;");
            CreditBase creditManager = new CreditManager();
            startTime = DateTime.Now;
            Console.WriteLine(creditManager.Calculate() + $" - {(DateTime.Now - startTime).Seconds} seconds passed");
            Console.WriteLine(creditManager.Calculate() + $" - {(DateTime.Now - startTime).Seconds} seconds passed");
            Console.WriteLine(creditManager.Calculate() + $" - {(DateTime.Now - startTime).Seconds} seconds passed");

            //Test with proxy
            Console.WriteLine("\nWith proxy design;");
            CreditBase creditManager2 = new CreditManagerProxy();
            startTime = DateTime.Now;
            Console.WriteLine(creditManager2.Calculate() + $" - {(DateTime.Now - startTime).Seconds} seconds passed");
            Console.WriteLine(creditManager2.Calculate() + $" - {(DateTime.Now - startTime).Seconds} seconds passed");
            Console.WriteLine(creditManager2.Calculate() + $" - {(DateTime.Now - startTime).Seconds} seconds passed");
        }
    }

    public abstract class CreditBase
    {
        public abstract int Calculate();
    }

    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 0; i < 10; i++)
            {
                result += result;
                Thread.Sleep(150);
            }

            return result;
        }
    }

    public class CreditManagerProxy : CreditBase
    {
        private CreditManager _creditManager;
        private int _cachedCalculation;
       
        public CreditManagerProxy()
        {
            
        }
        public override int Calculate()
        {
            if (_creditManager == null)
            {
                _creditManager = new CreditManager();
                _cachedCalculation = _creditManager.Calculate();
            }

            return _cachedCalculation;
        }
    }
}
