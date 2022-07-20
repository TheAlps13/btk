using System;

namespace facade_design_method
{
    public class Logging : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged!");
        }
    }

}
