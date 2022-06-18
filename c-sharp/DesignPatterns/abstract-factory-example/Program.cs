using abstract_factory_example.Cache.Abstract;
using abstract_factory_example.Cache.Concrete;
using abstract_factory_example.Log.Abstract;
using abstract_factory_example.Log.Concrete;
using System;

namespace abstract_factory_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new MemCache();
        }

        public override Logging CreateLogging()
        {
            return new NLogger();
        }
    }
}
