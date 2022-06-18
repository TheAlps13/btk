using abstract_factory_example.Log.Abstract;
using System;

namespace abstract_factory_example.Log.Concrete
{
    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4net");
        }
    }
}
