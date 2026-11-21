using StudentPerformance.Validation;

namespace StudentPerformance.Models;

public sealed class StudentGroup
{
    private StudentGroup(int id, int studyStreamId, string number)
    {
        Id = id;
        StudyStreamId = studyStreamId;
        Number = number;
    }

    public int Id { get; private set; }
    public int StudyStreamId { get; private set; }
    public string Number { get; private set; }

    public static StudentGroup Create(int id, int studyStreamId, string? number)
    {
        return new StudentGroup(
            Guard.NotNegative(id, "Идентификатор"),
            Guard.RequiredReference(studyStreamId, "Поток"),
            Guard.NotBlank(number, "Номер группы"));
    }
}
