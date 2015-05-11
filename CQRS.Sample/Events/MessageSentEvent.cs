using CQRS.Sample.Domain;
using CQRS.Sample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS.Sample.Events
{
    public class MessageSentEvent : IEvent
    {
        public MessageSentEvent(Message message)
        {
            this.Message = message;
        }

        public Message Message { get; set; }
    }
}
