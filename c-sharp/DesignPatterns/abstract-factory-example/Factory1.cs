using abstract_factory_example.Cache.Abstract;
using abstract_factory_example.Cache.Concrete;
using abstract_factory_example.Log.Abstract;
using abstract_factory_example.Log.Concrete;

namespace abstract_factory_example
{
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
