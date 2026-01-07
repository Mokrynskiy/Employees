namespace Employees.Domain.Departments;

/// <summary>
/// Подразделение
/// </summary>
public class Department
{
    /// <summary>
    /// Уникальный идентификатор подразделения
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// Наименование подразделения
    /// </summary>
    public string Name { get; private set; } = default!;
}
