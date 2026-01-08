using Employees.Domain.Departments;
using Employees.Infrastructure.Data;

namespace Employees.Infrastructure.Departments;

public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
{
    public DepartmentRepository(EmployeesDbContext context) : base(context)
    {        
    }
}
