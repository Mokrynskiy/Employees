using Employees.Domain.Departments;
using Employees.Domain.Employees;
using Employees.Domain.Positions;
using Microsoft.EntityFrameworkCore;

namespace Employees.Infrastructure.Data;

public class EmployeesDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; }

    public DbSet<Position> Positions { get; set; }

    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data source=employees.db");
            optionsBuilder.UseSnakeCaseNamingConvention();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeesDbContext).Assembly);
}
