using EmpManagement.Model;
using Microsoft.EntityFrameworkCore;


namespace EmpManagement.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
