namespace Employees.Domain.WorkHistories;

/// <summary>
/// Предыдущее место работы
/// </summary>
public class WorkHistory
{
    /// <summary>
    /// Уникальный идентификатор записи
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Наименование организации
    /// </summary>
    public string OrganizationName { get; private set; } = default!;

    /// <summary>
    /// Адрес организации
    /// </summary>
    public string Address { get; private set; } = default!;

    /// <summary>
    /// Телефон организации
    /// </summary>
    public string Phone { get; private set; } = default!;

    /// <summary>
    /// Должность
    /// </summary>
    public string Post { get; private set; } = default!;

    /// <summary>
    /// Дата начала работы
    /// </summary>
    public DateTime StartDate { get; private set; }

    /// <summary>
    /// Дата увольнения
    /// </summary>
    public DateTime EndDate { get; private set; }

    /// <summary>
    /// Причина увольнения
    /// </summary>
    public string ReasonOfDismissal { get; private set; } = default!;
}
