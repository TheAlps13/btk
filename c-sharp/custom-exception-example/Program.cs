using System;
using System.Collections.Generic;

namespace custom_exception_example
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Find("Alpe");
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        static void Find(string name)
        {
            List<string> rockers = new()
            {
                "Alper",
                "Kemal",
                "Fatih",
                "Emrah"
            };
            if (!rockers.Contains(name))
                throw new RecordNotFoundException("There is no record as " + name);
        }
    }
}
