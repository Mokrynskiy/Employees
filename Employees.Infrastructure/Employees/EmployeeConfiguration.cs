using Employees.Domain.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Employees.Infrastructure.Employees;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable("employees");

        builder.Property(x => x.LastName).IsRequired();

        builder.Property(x => x.LastName).HasMaxLength(50);

        builder.Property(x => x.FirstName).IsRequired();
        
        builder.Property(x => x.FirstName).HasMaxLength(50);
         
        builder.Property(x => x.Patronymic).HasMaxLength(50);
    }
}
