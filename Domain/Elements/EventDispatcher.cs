using DDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Elements
{
    public class EventDispatcher : IEventDispatcher
    {
        public void Dispatch<T>(List<T> events) where T : IDomainEvent
        {
            foreach (var e in events)
            {
                var Handlers = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.GetTypes()
                .Where(x => x.GetInterfaces()
                .Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IEventHandler<>) 
                && x.GenericTypeArguments[0] == e.GetType())));

                foreach (var Handler in Handlers)
                {
                    var instance = Activator.CreateInstance(Handler);
                    var method = instance?.GetType().GetRuntimeMethods().First(x => x.Name.Equals("Handle"));
                    var param = new object[] { e };
                    method?.Invoke(instance, param);
                }
            }            
        }
    }
}
