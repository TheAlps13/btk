using System;

namespace adapter_design_method
{
    class ProductManager
    {
        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Log("Logged beybe");
            Console.WriteLine("Saved!");
        }
    }
}
