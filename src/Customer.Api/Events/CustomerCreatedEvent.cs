using System.Collections.Generic;
using System.Linq;
using Customer.Api.Models.Mongo;
using Customer.Api.Models.Sqlite;

namespace Customer.Api.Events
{
    public class CustomerCreatedEvent : IEvent
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<PhoneCreatedEvent> Phones { get; set; }

        public CustomerEntity ToCustomerEntity()
        {
            return new CustomerEntity
            {
                Id = this.Id,
                Email = this.Email,
                Name = this.Name,
                Age = this.Age,
                Phones = this.Phones.Select(p =>
                {
                    return new PhoneEntity
                    {
                        Type = p.Type,
                        AreaCode = p.AreaCode,
                        Number = p.Number
                    };
                }).ToList()
            };
        }
    }
}