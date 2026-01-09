using Employees.Domain.AcademicDegrees;
using Employees.Domain.AcademicTitles;
using Employees.Domain.EducationTypes;
using Employees.Domain.Employees;
using Employees.Domain.Genders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Employees.Infrastructure.Employees;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable("employees");

        builder.Property(x => x.LastName)
            .IsRequired();

        builder.Property(x => x.LastName)
            .HasMaxLength(50);

        builder.Property(x => x.FirstName)
            .IsRequired();
        
        builder.Property(x => x.FirstName)
            .HasMaxLength(50);
         
        builder.Property(x => x.Patronymic)
            .HasMaxLength(50);

        builder.Property(x => x.DateOfBirth)
            .IsRequired();

        builder.Property(x => x.Address)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Phone)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(x => x.StartDateOfWork)
            .IsRequired();

        builder.Property(x => x.PassportDate)
            .IsRequired();

        builder.Property(x => x.PassportSeries)
            .IsRequired()
            .HasMaxLength(4);

        builder.Property(x => x.PassportNumber)
            .IsRequired()
            .HasMaxLength(6);

        builder.Property(x => x.WhoIssuedPassport)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Gender)
            .HasConversion(new EnumToNumberConverter<Gender, byte>());

        builder.Property(x => x.AcademicDegree)
            .HasConversion(new EnumToNumberConverter<AcademicDegree, byte>());

        builder.Property(x => x.AcademicTitle)
            .HasConversion(new EnumToNumberConverter<AcademicTitle, byte>());

        builder.Property(x => x.EducationType)
            .HasConversion(new EnumToNumberConverter<EducationType, byte>());

        builder.Property(x => x.EducationDocumentName)
            .HasMaxLength(50);

        builder.Property(x => x.EducutionDocumentNumber)
            .HasMaxLength(50);

        builder.Property(x => x.InstitutionName)
            .HasMaxLength(250);

        builder.Property(x => x.Specialization)
            .HasMaxLength(150);

        builder.Property(x => x.PhotoPath)
            .HasMaxLength(150);

    builder.OwnsMany(x => x.Rewarings, r =>
        {
            r.WithOwner().HasForeignKey("employee_id");

            r.ToTable("rewarings");

            r.HasKey(x => x.Id);

            r.Property(x => x.OrderNumber)
                .IsRequired()
                .HasMaxLength(50);

            r.Property(x => x.OrderDate)
                .IsRequired();

            r.Property(x => x.Type)
                .IsRequired()
                .HasMaxLength(250);
        });

        builder.OwnsMany(x => x.Penalizings, p =>
        {
            p.WithOwner().HasForeignKey("employee_id");

            p.ToTable("penalazings");

            p.HasKey(x => x.Id);

            p.Property(x => x.OrderNumber)
                .IsRequired()
                .HasMaxLength(50);

            p.Property(x => x.OrderDate)
                .IsRequired();

            p.Property(x => x.Type)
                .IsRequired()
                .HasMaxLength(250);
        });

        builder.OwnsMany(x => x.WorkHistory, w =>
        {
            w.WithOwner().HasForeignKey("employee_id");

            w.ToTable("work_histories");

            w.HasKey(x => x.Id);

            w.Property(x => x.Post)
                .IsRequired()
                .HasMaxLength(100);

            w.Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(150);

            w.Property(x => x.OrganizationName)
                .IsRequired()
                .HasMaxLength (100);

            w.Property(x => x.ReasonOfDismissal)
                .IsRequired()
                .HasMaxLength(100);

            w.Property(x => x.StartDate)
                .IsRequired();

            w.Property(x => x.EndDate)
                .IsRequired();
        });

        builder.OwnsMany(x => x.Career, c =>
        {
            c.WithOwner().HasForeignKey("employee_id");

            c.ToTable("careers");

            c.HasKey(x => x.Id);

            c.HasOne(x => x.Department)
                .WithMany()
                .HasForeignKey(x => x.DepartmentId);

            c.HasOne(x => x.Position)
                .WithMany()
                .HasForeignKey(x => x.PositionId);

            c.Property(x => x.OrderDate)
                .IsRequired();

            c.Property(x => x.OrderNumber)
                .IsRequired()
                .HasMaxLength(50);

            c.Property(x => x.Reason)
                .IsRequired()
                .HasMaxLength(150);
        });
    }
}
