using StudentPerformance.Validation;

namespace StudentPerformance.Models;

public sealed class Student
{
    private static readonly DateTime MinBirthDate = new(1900, 1, 1);

    private Student(int id, int groupId, string fullName, DateTime birthDate)
    {
        Id = id;
        GroupId = groupId;
        FullName = fullName;
        BirthDate = birthDate;
    }

    public int Id { get; private set; }
    public int GroupId { get; private set; }
    public string FullName { get; private set; }
    public DateTime BirthDate { get; private set; }

    public static Student Create(int id, int groupId, string? fullName, DateTime birthDate)
    {
        return new Student(
            Guard.NotNegative(id, "Идентификатор"),
            Guard.RequiredReference(groupId, "Группа"),
            Guard.NotBlank(fullName, "ФИО студента"),
            Guard.DateInRange(birthDate, MinBirthDate, DateTime.Today, "Дата рождения"));
    }
}
