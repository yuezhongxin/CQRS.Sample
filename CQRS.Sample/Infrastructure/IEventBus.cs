using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS.Sample.Infrastructure
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event)
            where TEvent : IEvent;
    }
}
