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
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            _db = client.GetDatabase(_customerDB);
        }

        public List<CustomerEntity> GetCustomers()
        {
            return _db.GetCollection<CustomerEntity>(_customers)
                .Find(_ => true).ToList();
        }

        public CustomerEntity GetCustomerById(long id)
        {
            return _db.GetCollection<CustomerEntity>(_customers)
                .Find(c => c.Id == id).SingleOrDefault();
        }

        public CustomerEntity GetCustomerByEmail(string email)
        {
            return _db.GetCollection<CustomerEntity>(_customers)
                .Find(c => c.Email == email).SingleOrDefault();
        }

        public void Create(CustomerEntity customer)
        {
            _db.GetCollection<CustomerEntity>(_customers)
                .InsertOne(customer);
        }

        public void Update(CustomerEntity customer)
        {
            var filter = Builders<CustomerEntity>.Filter
                .Where(c => c.Id == customer.Id);
            _db.GetCollection<CustomerEntity>(_customers)
                .ReplaceOne(filter, customer);
        }

        public void Remove(long id)
        {
            var filter = Builders<CustomerEntity>.Filter
                .Where(c => c.Id == id);
            _db.GetCollection<CustomerEntity>(_customers)
                .DeleteOne(filter);
        }
    }
}