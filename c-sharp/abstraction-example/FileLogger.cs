using System;

namespace abstraction_example
{
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");      
        }
    }
}