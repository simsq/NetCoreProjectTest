using DataLibrary.Domain;
using Microsoft.EntityFrameworkCore;

namespace DataLibrary
{
    public class EFProjectContext : DbContext
    {
        public EFProjectContext(DbContextOptions<EFProjectContext> options) : base(options)
        {

        }

        public DbSet<Address> Addreses { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<OrderMaster> OrderMasters { get; set; }

        public DbSet<OrderStatu> OrderStatus { get; set; }

    }
}
