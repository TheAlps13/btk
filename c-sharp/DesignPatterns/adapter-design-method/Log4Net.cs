using System;

namespace adapter_design_method
{
    // Sample from Nuget
    class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Logged with Log4Net: {message}");
        }
    }
}
