using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces
{
    public interface IMessageProducer
    {
        void SendMessage<T>(T message);
    }
}
