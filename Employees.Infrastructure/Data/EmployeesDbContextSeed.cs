using Employees.Domain.Departments;
using Employees.Domain.Positions;

namespace Employees.Infrastructure.Data;

public class EmployeesDbContextSeed
{
    public void Seed(EmployeesDbContext context)
    {
        var dept1 = context.Departments.Add(Department.Create("Отбел кадров"));
        var dept2 = context.Departments.Add(Department.Create("Бухгалтерия"));

        var post1 = context.Positions.Add(Position.Create("Старший специалист"));
        var post2 = context.Positions.Add(Position.Create("Главный бухгалтер"));

        context.SaveChanges();


    }   
}
