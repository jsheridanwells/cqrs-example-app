using Customer.Api.Models.Sqlite;
using MongoDB.Bson.Serialization.Attributes;

namespace Customer.Api.Models.Mongo
{
    public class PhoneEntity
    {
        [BsonElement("Typek")]
        public PhoneType Type { get; set; }
        
        [BsonElement("AreaCode")]
        public int AreaCode { get; set; }
        
        [BsonElement("Number")]
        public int Number { get; set; }
    }
}