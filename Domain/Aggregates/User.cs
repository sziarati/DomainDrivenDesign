using DDD.Domain.Base;
using DDD.Domain.Events;
using DDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Aggregates
{
    public class User : BaseEntity
    {
        //private readonly IMessageProducer messagePublisher;
        private readonly IEventDispatcher eventDispatcher;

        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; }
        
        public User(/*IMessageProducer messagePublisher,*/ IEventDispatcher eventDispatcher)/*:base(messagePublisher)*/
        {
            //this.messagePublisher = messagePublisher;
            this.eventDispatcher = eventDispatcher;
        }
        public void PasswordChange()
        {
            AddEvent(new PasswordChanedDomainEvent());
            eventDispatcher.Dispatch(Events);

        }
    }
}
