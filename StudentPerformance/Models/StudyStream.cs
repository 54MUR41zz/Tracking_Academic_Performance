using StudentPerformance.Validation;

namespace StudentPerformance.Models;

public sealed class StudyStream
{
    private const int MinAdmissionYear = 1950;
    private const int MaxAdmissionYear = 2100;

    private StudyStream(int id, int departmentId, int admissionYear)
    {
        Id = id;
        DepartmentId = departmentId;
        AdmissionYear = admissionYear;
    }

    public int Id { get; private set; }
    public int DepartmentId { get; private set; }
    public int AdmissionYear { get; private set; }

    public static StudyStream Create(int id, int departmentId, int admissionYear)
    {
        return new StudyStream(
            Guard.NotNegative(id, "Идентификатор"),
            Guard.RequiredReference(departmentId, "Кафедра"),
            Guard.InRange(admissionYear, MinAdmissionYear, MaxAdmissionYear, "Год набора"));
    }
}
