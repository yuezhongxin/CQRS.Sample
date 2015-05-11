using CQRS.Sample.CommandHandlers;
using CQRS.Sample.Commands;
using CQRS.Sample.Events;
using CQRS.Sample.Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize();
            var commond = new SendMessageCommond()
            {
                Title = "this is title",
                Content = "this is content",
                SenderLoginName = "this is senderLoginName",
                RecipientDisplayName = "this is recipientDisplayName"
            };
            var commandBus = IocContainer.Default.Resolve<CommandBus>();
            commandBus.Send(commond);
        }

        static void Initialize()
        {
            UnityContainer container = IocContainer.Default;
            container.RegisterType<ICommandBus, CommandBus>();
            container.RegisterType<IEventBus, EventBus>();
            container.RegisterType<ICommandHandler<SendMessageCommond>, SendMessageCommondHandler>();
            container.RegisterType<IEventHandler<MessageSentEvent>, MessageSentEventHandler>();
            container.RegisterType<IEventHandler<MailSentEvent>, MessageSentEventHandler>();
        }
    }

    public class IocContainer
    {
        public static UnityContainer Default = new UnityContainer();
    }
}
