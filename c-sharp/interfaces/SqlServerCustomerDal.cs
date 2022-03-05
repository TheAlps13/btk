using System;

namespace interfaces
{
    class SqlServerCustomer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}