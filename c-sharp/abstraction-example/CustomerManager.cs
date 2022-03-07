using System;

namespace abstraction_example
{
    class CustomerManager
    {
        private ILogger logger;

        public CustomerManager(ILogger logger)
        {
            this.logger = logger;
        }
        public void Add()
        {
           logger.Log();
           Console.WriteLine("Customer added!");
        }
    }
}