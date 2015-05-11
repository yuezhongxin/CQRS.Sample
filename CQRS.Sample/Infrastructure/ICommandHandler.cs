using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS.Sample.Infrastructure
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        void Handle(TCommand cmd);
    }
}
