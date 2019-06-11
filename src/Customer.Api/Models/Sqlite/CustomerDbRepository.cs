using System.Linq;

namespace Customer.Api.Models.Sqlite
{
    public class CustomerDbRepository : ICustomerDbRepository
    {
        private readonly CustomerDbContext _context;
        public CustomerDbRepository(CustomerDbContext context)
        {
            _context = context;
        }
        public CustomerRecord Create(CustomerRecord customer)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<CustomerRecord> entry = _context.Customers.Add(customer);
            _context.SaveChanges();
            return entry.Entity;
        }
        public void Update(CustomerRecord customer)
        {
            _context.SaveChanges();
        }
        public void Remove(long id)
        {
            _context.Customers.Remove(GetById(id));
            _context.SaveChanges();
        }
        public IQueryable<CustomerRecord> GetAll()
        {
            return _context.Customers;
        }
        public CustomerRecord GetById(long id)
        {
            return _context.Customers.Find(id);
        }
    }
}
