namespace bridge_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            MessageSenderBase messageSender = new SmsSender();
            messageSender.AddToSenderList(new EMailSender());
            customerManager.MessageSenderBase = messageSender;
            
            customerManager.UpdateCustomer(new Body
            {
                Title = "Alper",
                Text = "Hello there !"
            });

        }
    }
}
