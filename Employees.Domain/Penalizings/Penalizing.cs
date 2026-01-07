namespace Employees.Domain.Penalizings;

/// <summary>
/// Взыскание
/// </summary>
public class Penalizing
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Тип взыскания
    /// </summary>
    public string Type { get; private set; } = default!;

    /// <summary>
    /// Дата приказа о взыскании
    /// </summary>
    public DateOnly OrderDate { get; private set; }

    /// <summary>
    /// Номер приказа о взыскании
    /// </summary>
    public string OrderNumber { get; private set; } = default!;
}
