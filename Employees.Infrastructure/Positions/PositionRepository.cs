using Employees.Domain.Positions;
using Employees.Infrastructure.Data;

namespace Employees.Infrastructure.Positions;

public class PositionRepository : RepositoryBase<Position>, IPositionRepository
{
    public PositionRepository(EmployeesDbContext context) : base(context)
    {        
    }
}
