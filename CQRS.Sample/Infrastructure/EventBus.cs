using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Sample.Infrastructure
{
    public class EventBus : IEventBus
    {
        public void Publish<TEvent>(TEvent @event)
            where TEvent : IEvent
        {
            var eventHandler = IocContainer.Default.Resolve<IEventHandler<TEvent>>();
            eventHandler.Handle(@event);
        }
    }
}
