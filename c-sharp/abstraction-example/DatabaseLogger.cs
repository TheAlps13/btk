using System;

namespace abstraction_example
{
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");           
        }
    }
}