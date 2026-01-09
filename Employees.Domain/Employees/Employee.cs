using Employees.Domain.AcademicDegrees;
using Employees.Domain.AcademicTitles;
using Employees.Domain.Careers;
using Employees.Domain.Genders;
using Employees.Domain.Penalizings;
using Employees.Domain.Rewarings;
using Employees.Domain.WorkHistories;

namespace Employees.Domain.Employees;

/// <summary>
/// Сотрудник
/// </summary>
public class Employee
{
    /// <summary>
    /// Уникальный идентификатор работника
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; private set; } = default!;

    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; private set; } = default!;

    /// <summary>
    /// Отчество
    /// </summary>
    public string Patronymic { get; private set; } = default!;

    /// <summary>
    /// Пол
    /// </summary>
    public Gender Gender { get; private set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime DateOfBirth { get; private set; }

    /// <summary>
    /// Место рождения
    /// </summary>
    public string PlaceOfBirth { get; private set; } = default!;

    /// <summary>
    /// Адрес проживания
    /// </summary>
    public string Address { get; private set; } = default!;

    /// <summary>
    /// Телефон
    /// </summary>
    public string Phone { get; private set; } = default!;

    /// <summary>
    /// Серия паспорта
    /// </summary>
    public string PassportSeries { get; private set; } = default!;

    /// <summary>
    /// Номер паспорта
    /// </summary>
    public string PassportNumber { get; private set; } = default!;

    /// <summary>
    /// Дата выдачи паспорта
    /// </summary>
    public DateTime PassportDate { get; private set; }

    /// <summary>
    /// Кто выдал паспорт
    /// </summary>
    public string WhoIssuedPassport { get; private set; } = default!;

    /// <summary>
    /// Дата начала трудовой деятельности
    /// </summary>
    public DateTime StartDateOfWork { get; private set; }

    /// <summary>
    /// Ученая степень
    /// </summary>
    public AcademicDegree AcademicDegree { get; private set; }

    /// <summary>
    /// Ученое звание
    /// </summary>
    public AcademicTitle AcademicTitle { get; private set; }

    private readonly List<Career> career = [];

    /// <summary>
    /// Перемещения (назначения на должность)
    /// </summary>
    public IReadOnlyCollection<Career> Career => career.AsReadOnly();

    private readonly List<Rewaring> rewarings = [];

    /// <summary>
    /// Поощерения
    /// </summary>
    public IReadOnlyCollection<Rewaring> Rewarings => rewarings.AsReadOnly();

    private readonly List<Penalizing> penalizings = [];

    /// <summary>
    /// Взыскания
    /// </summary>
    public IReadOnlyCollection<Penalizing> Penalizings => penalizings.AsReadOnly();

    private readonly List<WorkHistory> workHistory = [];

    /// <summary>
    /// Предыдущие места работы
    /// </summary>
    public IReadOnlyCollection<WorkHistory> WorkHistory => workHistory.AsReadOnly();

}
