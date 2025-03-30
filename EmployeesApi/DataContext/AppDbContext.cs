using EmployeesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesApi.DataContext

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) {}

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
