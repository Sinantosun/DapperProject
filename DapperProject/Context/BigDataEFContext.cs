using DapperProject.Entites;
using Microsoft.EntityFrameworkCore;

namespace DapperProject.Context
{
    public class BigDataEFContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public BigDataEFContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("BigDataEFConnection"));
        }

        public DbSet<SALES> Sales { get; set; }
    }
}
