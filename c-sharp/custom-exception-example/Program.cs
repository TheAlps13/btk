using System;
using System.Collections.Generic;
using static custom_exception_example.ExceptionHandler;
namespace custom_exception_example
{
    class Program
    {

        static void Main(string[] args)
        {
            HandleException(() =>
            {
                Find("Alpe");
            });
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
