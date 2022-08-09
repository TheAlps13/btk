using System;

namespace bridge_design_method
{
    public class SmsSender : MessageSenderBase
    {
        public SmsSender()
        {
            AddToSenderList(this);
        }
        public override void Send(Body body)
        {
            Console.WriteLine($"Message sent with {nameof(SmsSender)}");
            Console.WriteLine($"Message content: {body.Text}");
        }
    }
}
