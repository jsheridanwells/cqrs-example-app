using System.Linq;

namespace Customer.Api.Models.Sqlite
{
    public interface ICustomerDbRepository
    {
        CustomerRecord Create(CustomerRecord customer);
        void Update(CustomerRecord customer);
        void Remove(long id);
        IQueryable<CustomerRecord> GetAll();
        CustomerRecord GetById(long id);
    }
}