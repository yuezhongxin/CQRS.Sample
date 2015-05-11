using CQRS.Sample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS.Sample.Commands
{
    public class SendMessageCommond : ICommand
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string SenderLoginName { get; set; }
        public string RecipientDisplayName { get; set; }
    }
}
