using Customer.Api.Models.Sqlite;

namespace Customer.Api.Models.Mongo
{
    public class PhoneEntity
    {
        public PhoneType Type { get; set; }
        public int AreaCode { get; set; }
        public int Number { get; set; }
    }
}