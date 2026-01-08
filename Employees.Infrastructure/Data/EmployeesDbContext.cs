using Microsoft.EntityFrameworkCore;

namespace Employees.Infrastructure.Data;

public class EmployeesDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlite("Data source=employees.db");
    }
}
