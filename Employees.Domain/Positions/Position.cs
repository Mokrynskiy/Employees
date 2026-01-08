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

    /// <summary>
    /// Создание новой должности
    /// </summary>
    /// <param name="name">Наименование должности</param>
    /// <returns></returns>
    public static Position Create(string name)
    {
        var position = new Position
        {
            Name = name
        };

        return position;
    }
}
