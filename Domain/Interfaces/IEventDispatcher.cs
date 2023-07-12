using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces
{
    public interface IEventDispatcher
    {
        public void Dispatch<T>(List<T> events) where T : IDomainEvent;
    }
}
