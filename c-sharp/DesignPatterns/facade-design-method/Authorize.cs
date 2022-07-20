using System;

namespace facade_design_method
{
    public class Authorize : IAuthorizer
    {
        public void CheckUser()
        {
            Console.WriteLine("User checked!");
        }
    }

}
