using abstract_factory_example.Cache.Abstract;
using abstract_factory_example.Log.Abstract;
using System;

namespace abstract_factory_example
{
    public class ProductManager
    {
        private Logging _logging;
        private Caching _caching;
       
        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _logging = crossCuttingConcernsFactory.CreateLogging();
            _caching = crossCuttingConcernsFactory.CreateCaching();
        }
        public void GetAll()
        {
            _logging.Log("Hello");
            _caching.Cache("Data");
            Console.WriteLine("Products listed!");
        }
    }
        
}
