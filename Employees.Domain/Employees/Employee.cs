using Employees.Domain.AcademicDegrees;
using Employees.Domain.AcademicTitles;
using Employees.Domain.Careers;
using Employees.Domain.Departments;
using Employees.Domain.EducationTypes;
using Employees.Domain.Genders;
using Employees.Domain.Penalizings;
using Employees.Domain.Positions;
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
    /// Тип образования
    /// </summary>
    public EducationType EducationType { get; private set; }

    /// <summary>
    /// Наименование документа об образовании
    /// </summary>
    public string EducationDocumentName { get; private set; } = default!;

    /// <summary>
    /// Дата документа об образование
    /// </summary>
    public DateTime? EducationDocumentDate { get; private set; }

    /// <summary>
    /// Номер документа об образовании
    /// </summary>
    public string EducutionDocumentNumber { get; private set; } = default!;

    /// <summary>
    /// Наименование учебного заведения
    /// </summary>
    public string InstitutionName { get; private set; } = default!;

    /// <summary>
    /// Специальность
    /// </summary>
    public string Specialization { get; private set; } = default!;

    /// <summary>
    /// Путь к файлу фотографии
    /// </summary>
    public string PhotoPath { get; private set; } = default!;

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

    /// <summary>
    /// Создать нового сотрудника
    /// </summary>
    /// <param name="lastName"> Фамилия</param>
    /// <param name="firstName">Имя</param>
    /// <param name="patronymic">Отчество</param>
    /// <param name="gender">Пол</param>
    /// <param name="dateOfBirth">Дата рождения</param>
    /// <param name="placeOfBirth">Место рождения</param>
    /// <param name="address">Адрес проживания</param>
    /// <param name="phone">Телефон</param>
    /// <param name="passportSeries">Серия паспорта</param>
    /// <param name="passportNumber">Номер паспорта</param>
    /// <param name="passportDate">Дата выдачи паспорта</param>
    /// <param name="whoIssuedPassport">Кто выдал паспорт</param>
    /// <param name="StartDateOfWork">Дата начала трудовой деятельности</param>
    /// <param name="educationType">Тип образования</param>
    /// <param name="EducationDocumentName">Наименование документа об образовании</param>
    /// <param name="educationDocumentDate">Дата документа об образовании</param>
    /// <param name="educationDocumentNumber">Номер документа об образовании</param>
    /// <param name="institutionName">Наименование учебного заведения</param>
    /// <param name="specialization">Специальность</param>
    /// <param name="photoPath">Путь к фотографии</param>
    /// <param name="academicDegree">Ученая степень</param>
    /// <param name="academicTitle">Ученое звание</param>
    /// <param name="orderDate">Дата приказа о принятии на работу</param>
    /// <param name="orderNumber">Номер приказа о принятии на работу</param>
    /// <returns>Employee</returns>
    public static Employee Create(
        string lastName,
        string firstName,
        string patronymic,
        Gender gender,
        DateTime dateOfBirth,
        string placeOfBirth,
        string address,
        string phone,
        string passportSeries,
        string passportNumber,
        DateTime passportDate,
        string whoIssuedPassport,
        DateTime StartDateOfWork,
        EducationType educationType,
        string EducationDocumentName,
        DateTime? educationDocumentDate,
        string educationDocumentNumber,
        string institutionName,
        string specialization,
        string photoPath,
        AcademicDegree academicDegree,
        AcademicTitle academicTitle,
        string orderNumber,
        DateTime orderDate        
        )
    {
        return new Employee
        {
            LastName = lastName,
            FirstName = firstName,
            Patronymic = patronymic,
            Gender = gender,
            DateOfBirth = dateOfBirth,
            PlaceOfBirth = placeOfBirth,
            Address = address,
            Phone = phone,
            PassportSeries = passportSeries,
            PassportNumber = passportNumber,
            PassportDate = passportDate,
            WhoIssuedPassport = whoIssuedPassport,
            StartDateOfWork = StartDateOfWork,
            EducationType = educationType,
            EducationDocumentName = EducationDocumentName,
            EducationDocumentDate = educationDocumentDate,
            EducutionDocumentNumber = educationDocumentNumber,
            InstitutionName = institutionName,
            Specialization = specialization,
            PhotoPath = photoPath,
            AcademicDegree = academicDegree,
            AcademicTitle = academicTitle
        };
    }   
}
