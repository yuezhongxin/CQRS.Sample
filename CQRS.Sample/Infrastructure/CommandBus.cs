using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQRS.Sample.Commands;
using Microsoft.Practices.Unity;

namespace CQRS.Sample.Infrastructure
{
    public class CommandBus : ICommandBus
    {
        public void Send<TCommand>(TCommand cmd) 
            where TCommand : ICommand
        {
            var commandHandler = IocContainer.Default.Resolve<ICommandHandler<TCommand>>();
            commandHandler.Handle(cmd);
        }
    }
}
