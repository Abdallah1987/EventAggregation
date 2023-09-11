using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorExample
{
    public class EventAggregator
    {
        private readonly Dictionary<Type, List<object>> _subscribers = new Dictionary<Type, List<object>>();

        public void Subscribe<TEvent>(Action<TEvent> handler)
        {
            var eventType = typeof(TEvent);
            if (!_subscribers.ContainsKey(eventType))
            {
                _subscribers[eventType] = new List<object>();
            }
            _subscribers[eventType].Add(handler);
        }

        public void Publish<TEvent>(TEvent @event)
        {
            var eventType = typeof(TEvent);
            if (_subscribers.TryGetValue(eventType, out var handlers))
            {
                foreach (var handler in handlers)
                {
                    ((Action<TEvent>)handler)(@event);
                }
            }
        }
    }
}
