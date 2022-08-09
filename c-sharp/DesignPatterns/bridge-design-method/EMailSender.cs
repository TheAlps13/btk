using System;

namespace bridge_design_method
{
    public class EMailSender : MessageSenderBase
    {
        public EMailSender()
        {
            AddToSenderList(this);
        }
        public override void Send(Body body)
        {
            Console.WriteLine($"Message sent with {nameof(EMailSender)}");
            Console.WriteLine($"Message title: {body.Title}");
            Console.WriteLine($"Message content: {body.Text}");
        }
    }
}
