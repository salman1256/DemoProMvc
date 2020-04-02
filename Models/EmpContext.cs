using Microsoft.EntityFrameworkCore;

namespace DbEnabledApp.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Emp> Emps { get; set; }
    }
}
