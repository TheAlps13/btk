using abstract_factory_example.Cache.Abstract;
using abstract_factory_example.Log.Abstract;

namespace abstract_factory_example
{
    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogging();
        public abstract Caching CreateCaching();
    }
}
