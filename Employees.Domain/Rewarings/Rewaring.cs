namespace Employees.Domain.Rewarings;

/// <summary>
/// Поощерение
/// </summary>
public class Rewaring
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Тип поощерения
    /// </summary>
    public string Type { get; private set; } = default!;

    /// <summary>
    /// Дата приказа о поощерении
    /// </summary>
    public DateTime OrderDate { get; private set; }

    /// <summary>
    /// Номер приказа о поощерении
    /// </summary>
    public string OrderNumber { get; private set; } = default!;
}
