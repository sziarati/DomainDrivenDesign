using DDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Base
{
    public class BaseEntity
    {
        public readonly List<IDomainEvent> Events = new List<IDomainEvent>();
        //private readonly IMessageProducer messagePublisher;

        public BaseEntity(/*IMessageProducer messagePublisher*/)
        {
            //this.messagePublisher = messagePublisher;
        }
        public int Id { get; set; }
        public void AddEvent(IDomainEvent domainEvent)
        {
            Events.Add(domainEvent);
        }
        public void RemoveEvent(IDomainEvent domainEvent)
        {
            Events.Remove(domainEvent);
        }
    }
}
