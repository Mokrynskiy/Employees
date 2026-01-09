namespace Employees.Domain.EducationTypes;

/// <summary>
/// Тип образования
/// </summary>
public enum EducationType
{
    /// <summary>
    /// Без образования
    /// </summary>
    WithoutEducation = 0,

    /// <summary>
    /// Неполное среднее образование
    /// </summary>
    IncompleteSecondary = 1,

    /// <summary>
    /// Среднее образование
    /// </summary>
    Secondary = 2,

    /// <summary>
    /// Среднее специальное образование
    /// </summary>
    SecondarySpecialized = 3,

    /// <summary>
    /// Высшее образование
    /// </summary>
    Higher = 4
}
