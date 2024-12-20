using EmployeeAdminPortal.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)

        {
            
        }

        public DbSet<Label> Labels { get; set; }
        public DbSet<Model.Entities.Task> Tasks { get; set; }
    }
}
