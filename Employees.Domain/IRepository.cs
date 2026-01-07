using System.Linq.Expressions;

namespace Employees.Domain;

public interface IRepository<T> where T : class
{
    /// <summary>
    /// Найти все записи
    /// </summary>
    /// <param name="trackChanges"></param>
    /// <returns></returns>
    IQueryable<T> FindAll(bool trackChanges);

    /// <summary>
    /// Найти записи с условием
    /// </summary>
    /// <param name="expression"></param>
    /// <param name="trackChanges"></param>
    /// <returns></returns>
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

    /// <summary>
    /// Добавить элемент
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    T Add(T item);

    /// <summary>
    /// Добавить элементы
    /// </summary>
    /// <param name="items"></param>
    void AddRange(IEnumerable<T> items);

    /// <summary>
    /// Обновить элемент
    /// </summary>
    /// <param name="item"></param>
    void Update(T item);

    /// <summary>
    /// Удалить элемент
    /// </summary>
    /// <param name="item"></param>
    void Delete(T item);

    /// <summary>
    /// Удалить элементы
    /// </summary>
    /// <param name="expression"></param>
    void Delete(Expression<Func<T, bool>> expression);

    void Save();
}
