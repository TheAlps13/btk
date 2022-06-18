using abstract_factory_example.Cache.Abstract;
using System;

namespace abstract_factory_example.Cache.Concrete
{
    public class RedisCache : Caching
    {
        public override void Cache(string cache)
        {
            Console.WriteLine("Cached with RedisCache");
        }
    }
}
