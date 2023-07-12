using DDD.Domain.Events;
using DDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Handlers
{
    public class PasswordChanedEmailEventHandler: IEventHandler<PasswordChanedDomainEvent>
    {
        public void Handle(PasswordChanedDomainEvent @event)
        {
            Console.WriteLine("Email Sent");
        }
    }
    public class PasswordChanedSMSEventHandler : IEventHandler<PasswordChanedDomainEvent>
    {
        public void Handle(PasswordChanedDomainEvent @event)
        {
            Console.WriteLine("SMS Sent");
        }
    }
}
