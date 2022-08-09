using System;
using System.Collections.Generic;

namespace bridge_design_method
{
    public abstract class MessageSenderBase
    {
        private List<MessageSenderBase> _messageSenders = new List<MessageSenderBase>();

        public void Save()
        {
            Console.WriteLine("Saved !");
        }

        public void AddToSenderList(MessageSenderBase messageSender)
        {
            _messageSenders.Add(messageSender);
        }
        public void SendAllChannels(Body body)
        {
            foreach (var messageSender in _messageSenders)
                messageSender.Send(body);
        }
        public abstract void Send(Body body);
    }
}
