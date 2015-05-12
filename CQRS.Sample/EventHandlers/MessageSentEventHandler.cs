using CQRS.Sample.Commands;
using CQRS.Sample.Domain;
using CQRS.Sample.Domain.DomainServices;
using CQRS.Sample.Events;
using CQRS.Sample.Infrastructure;
using CQRS.Sample.Repositories;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Sample.EventHandlers
{
    public class MessageSentEventHandler : 
        IEventHandler<MessageSentEvent>,
        IEventHandler<MailSentEvent>
    {
        private IEventBus eventBus;

        public void Handle(MessageSentEvent @event)
        {
            eventBus = IocContainer.Default.Resolve<IEventBus>();
            //new MessageRepository().Save<Message>(@event.Message);
            eventBus.Publish(new MailSentEvent
            {
                Title = @event.Message.Title,
                Content = @event.Message.Title,
            });
        }

        public void Handle(MailSentEvent @event)
        {
            var mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.Subject = @event.Title;
            mailMessage.Body = @event.Content;
            mailMessage.IsBodyHtml = true;
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            mailMessage.Priority = System.Net.Mail.MailPriority.Normal;
            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient();
            //Task.Run(() => { smtpClient.SendAsync(mailMessage, mailMessage.Body); });
        }
    }
}
