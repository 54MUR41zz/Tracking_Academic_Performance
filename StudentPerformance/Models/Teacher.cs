using StudentPerformance.Validation;

namespace StudentPerformance.Models;

public sealed class Teacher
{
    private Teacher(int id, string fullName, string position)
    {
        Id = id;
        FullName = fullName;
        Position = position;
    }

    public int Id { get; private set; }
    public string FullName { get; private set; }
    public string Position { get; private set; }

    public static Teacher Create(int id, string? fullName, string? position)
    {
        return new Teacher(
            Guard.NotNegative(id, "Идентификатор"),
            Guard.NotBlank(fullName, "ФИО преподавателя"),
            Guard.NotBlank(position, "Должность"));
    }
}
