using System;

namespace custom_exception_example
{
    public class ExceptionHandler
    {
        public static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}