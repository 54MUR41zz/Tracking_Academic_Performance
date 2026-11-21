using StudentPerformance.Validation;

namespace StudentPerformance.Models;

public sealed class Subject
{
    private const int MinHours = 1;
    private const int MaxHours = 1000;

    private Subject(int id, string name, int hours)
    {
        Id = id;
        Name = name;
        Hours = hours;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Hours { get; private set; }

    public static Subject Create(int id, string? name, int hours)
    {
        return new Subject(
            Guard.NotNegative(id, "Идентификатор"),
            Guard.NotBlank(name, "Наименование дисциплины"),
            Guard.InRange(hours, MinHours, MaxHours, "Количество часов"));
    }
}
