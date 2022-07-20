using System;

namespace facade_design_method
{
    public class Validation : IValidate
    {
        public void Validate()
        {
            Console.WriteLine("Validated!");
        }
    }

}
