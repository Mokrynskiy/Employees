using Employees.Domain.Departments;
using Employees.Domain.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain.Careers;

/// <summary>
/// Перемещение (назначение на должность)
/// </summary>
public class Career
{
    /// <summary>
    /// Уникальный идентификатор записи
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Дата приказа
    /// </summary>
    public DateOnly OrderDate { get; private set; }

    /// <summary>
    /// Номер приказа
    /// </summary>
    public string OrderNumber { get; private set; } = default!;

    /// <summary>
    /// Причина перемещения (назначения на должность)
    /// </summary>
    public string Reason { get; private set; } = default!;

    /// <summary>
    /// Уникальный идентификатор подразделения
    /// </summary>
    public int DepartmentId { get; private set; }

    /// <summary>
    /// Подразделение (Навигационное свойство)
    /// </summary>
    public Department Department { get; private set; } = default!;

    /// <summary>
    /// Уникальный идентификатор должности
    /// </summary>
    public int PositionId { get; private set; }

    /// <summary>
    /// Должность (Навигационное свойство)
    /// </summary>
    public Position Position { get; private set; } = default!;
}
