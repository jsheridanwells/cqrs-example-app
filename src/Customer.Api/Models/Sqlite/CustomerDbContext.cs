using Microsoft.EntityFrameworkCore;

namespace Customer.Api.Models.Sqlite
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> opts) : base(opts)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomerRecord>()
                .HasMany(x => x.Phones);
        }
        
        public DbSet<CustomerRecord> Customers { get; set; }
    }
}