using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-L8OVHQ2;database=PortalProjectDb;integrated security=true;");
        }

        public DbSet<PortalkahveCustomer> PortalkahveCustomers { get; set; }
        public DbSet<SturbucksCustomer> SturbucksCustomers { get; set; }
    }
}
