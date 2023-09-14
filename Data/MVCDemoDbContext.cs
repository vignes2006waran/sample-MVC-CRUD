using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using sample_MVC_CRUD.Models.Domain;

namespace sample_MVC_CRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
