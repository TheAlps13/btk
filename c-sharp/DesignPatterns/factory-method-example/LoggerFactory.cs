using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example
{
    public class LoggerFactory : ILoggerFactory
    {
        public static ILogger CreateInstance(string type)
        {
            // Business to decide factory type
            if(type == "Joker")
            {
                return new JokeLogger();
            }
            else
            {
                return new SeriousLogger();
            }
        }
    }
}
