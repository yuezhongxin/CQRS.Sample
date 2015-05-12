using CQRS.Sample.Commands;
using CQRS.Sample.Domain;
using CQRS.Sample.Domain.DomainServices;
using CQRS.Sample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS.Sample.CommandHandlers
{
    public class SendMessageCommondHandler : 
        ICommandHandler<SendMessageCommond>
    {
        public void Handle(SendMessageCommond command)
        {
            var sender = VerifySenderService.Verify(command.SenderLoginName);
            var receiver = VerifyReceiverService.Verify(command.RecipientDisplayName);
            var message = new Message(command.Title, command.Content, sender, receiver);
            message.Send();
        }
    }
}
