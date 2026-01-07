namespace Employees.Domain.Positions;

/// <summary>
/// Должность
/// </summary>
public class Position
{
    /// <summary>
    /// Уникальный идентификатор должности
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Наименование должности
    /// </summary>
    public string Name { get; private set; }
}
