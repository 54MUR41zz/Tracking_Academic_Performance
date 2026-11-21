using StudentPerformance.Enums;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Repositories.Stubs;

public sealed class GradeRepositoryStub : IGradeRepository
{
    private readonly List<Grade> grades =
    [
        Grade.Create(1, 1, 1, 1, 1, "2025/2026 осенний", AssessmentType.Exam, new DateTime(2026, 1, 20), 87),
        Grade.Create(2, 3, 1, 2, 2, "2025/2026 осенний", AssessmentType.Credit, new DateTime(2026, 1, 15), 74)
    ];

    private int lastId = 2;

    public IReadOnlyList<Grade> GetAll()
    {
        return grades.ToList();
    }

    public bool Exists(int studentId, int subjectId, string semester)
    {
        return grades.Any(grade => grade.StudentId == studentId
            && grade.SubjectId == subjectId
            && string.Equals(grade.Semester, semester, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(Grade grade)
    {
        ArgumentNullException.ThrowIfNull(grade);

        lastId++;
        grades.Add(Grade.Create(
            lastId,
            grade.StudentId,
            grade.TeacherId,
            grade.DepartmentId,
            grade.SubjectId,
            grade.Semester,
            grade.AssessmentType,
            grade.ExamDate,
            grade.Mark));
    }
}
