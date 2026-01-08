using Employees.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Employees.Infrastructure.Data;

public class RepositoryBase<T> : IRepository<T> where T : class
{
    protected EmployeesDbContext Context { get; set; }

    protected RepositoryBase(EmployeesDbContext context) => Context = context;
    public IQueryable<T> FindAll(bool trackChanges) => trackChanges ? Context.Set<T>() : Context.Set<T>().AsNoTracking();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
    trackChanges ?
    Context.Set<T>()
    .Where(expression) :
    Context.Set<T>()
    .Where(expression)
    .AsNoTracking();

    public T Add(T item) => Context.Set<T>().Add(item).Entity;

    public void Update(T item) => Context.Set<T>().Update(item);

    public void Delete(T item) => Context.Set<T>().Remove(item);

    public void Save() => Context.SaveChanges();

}
