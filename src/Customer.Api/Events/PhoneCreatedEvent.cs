using Customer.Api.Models;
using Customer.Api.Models.Sqlite;

namespace Customer.Api.Events
{
    public class PhoneCreatedEvent : IEvent
    {
        public PhoneType Type { get; set; }
        public int AreaCode { get; set; }
        public int Number { get; set; }
    }
}