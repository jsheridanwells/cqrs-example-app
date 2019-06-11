using System.Collections.Generic;

namespace Customer.Api.Models.Mongo
{
    public class CustomerEntity
    {
        public long Id { get; set; }
        public string Email{ get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<PhoneEntity> Phones { get; set; }
    }
}