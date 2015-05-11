using CQRS.Sample.Domain;
using CQRS.Sample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS.Sample.Events
{
    public class MailSentEvent : IEvent
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
