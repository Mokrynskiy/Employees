using Employees.Domain.Employees;
using Employees.Infrastructure.Data;

namespace Employees.Infrastructure.Employees;

public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployeeRepository(EmployeesDbContext context) : base(context)
    {        
    }
}
