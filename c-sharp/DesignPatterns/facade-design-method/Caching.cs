using System;

namespace facade_design_method
{
    public class Caching : ICacher
    {
        public void Cache()
        {
            Console.WriteLine("Cached!");
        }
    }

}
