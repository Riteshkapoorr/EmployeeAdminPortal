using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContext<ApplicationDbContext> options): base(options)

        {
            
        }
    }
}
