using Microsoft.EntityFrameworkCore;

namespace MVCDemo.Models
{
    public class EmpDbContext : DbContext
    {
        DbContextOptions<EmpDbContext> options;
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> employees { get; set; }
    }
}
