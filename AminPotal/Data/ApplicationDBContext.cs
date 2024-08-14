using AminPotal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AminPotal.Data
{
    public class ApplicationDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
