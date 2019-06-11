using System.Collections.Generic;
using MongoDB.Driver;

namespace Customer.Api.Models.Mongo
{
    public class CustomerMongoRepository
    {
        private const string _customerDB = "CustomerDB";
        private const string _customers = "Customers";
        private IMongoDatabase _db;
        public CustomerMongoRepository()
        {
            MongoClient _client = new MongoClient("mongodb://localhost:27017");
            _db = _client.GetDatabase(_customerDB);
        }

        public List<CustomerEntity> GetCustomers()
        {
            return _db.GetCollection<CustomerEntity>(_customers)
                .Find(_ => true).ToList();
        }

        public CustomerEntity GetCustomer(long id)
        {
            return _db.GetCollection<CustomerEntity>(_customers)
                .Find(c => c.Id == id).SingleOrDefault();
        }
    }
}