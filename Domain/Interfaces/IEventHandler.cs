using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces
{
    public interface IEventHandler<T> where T : IDomainEvent
    {
        void Handle(T @event);
    }
}
