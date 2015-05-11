using CQRS.Sample.Events;
using CQRS.Sample.Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Sample.Domain
{
    public class Message
    {
        private readonly IEventBus eventBus;

        public Message(string title, string content, Contact sender, Contact receiver)
        {
            Title = title;
            Content = content;
            Sender = sender;
            Receiver = receiver;
            eventBus = IocContainer.Default.Resolve<IEventBus>();
        }
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public Contact Sender { get; private set; }
        public Contact Receiver { get; private set; }
        public string IP { get; private set; }

        public void Send(Message message)
        {
            eventBus.Publish(new MessageSentEvent(message));
        }
    }
}
