using DDD.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Aggregates
{
    internal class Address : BaseValueObject<Address>
    {
        public string City { get; set; }
        public string State { get; set; }

        protected override bool Equals(Address other)
        {
            if (ReferenceEquals(null, other)) return false;
            else if 
                (ReferenceEquals(this, other)) return true;
            else return false;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return new object[] { City, State };
        }
    }
}
