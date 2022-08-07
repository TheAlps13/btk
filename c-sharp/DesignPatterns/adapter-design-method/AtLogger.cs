using System;

namespace adapter_design_method
{
    class AtLogger :ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged with AtLogger : {message}");
        }
    }
}
