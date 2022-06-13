using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example
{
    public class JokeLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + "\nLogged with JokeLogger");
        }
    }
}
