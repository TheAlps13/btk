namespace bridge_design_method
{
    public class CustomerManager
    {
        public MessageSenderBase MessageSenderBase { get; set; }

        public void UpdateCustomer(Body body)
        {
            MessageSenderBase.SendAllChannels(body);
        }
    }
}
