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

    /// <summary>
    /// Создать новое подразделение
    /// </summary>
    /// <param name="name">Наименование подразделения</param>
    /// <returns>Подразделение</returns>
    public static Department Create(string name)
    {
        var department = new Department { Name = name };
        return department;
    }
}
