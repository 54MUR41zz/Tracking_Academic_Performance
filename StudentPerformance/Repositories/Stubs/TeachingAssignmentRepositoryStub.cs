using StudentPerformance.Enums;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Repositories.Stubs;

public sealed class TeachingAssignmentRepositoryStub : ITeachingAssignmentRepository
{
    private readonly List<TeachingAssignment> assignments =
    [
        TeachingAssignment.Create(1, 1, 1, LessonTypes.Lecture | LessonTypes.Practice),
        TeachingAssignment.Create(1, 2, 2, LessonTypes.Lecture | LessonTypes.Laboratory),
        TeachingAssignment.Create(2, 3, 3, LessonTypes.Lecture | LessonTypes.Practice)
    ];

    public IReadOnlyList<TeachingAssignment> GetAll()
    {
        return assignments.ToList();
    }

    public bool Exists(int teacherId, int departmentId, int subjectId)
    {
        return assignments.Any(assignment => assignment.TeacherId == teacherId
            && assignment.DepartmentId == departmentId
            && assignment.SubjectId == subjectId);
    }

    public void Add(TeachingAssignment assignment)
    {
        ArgumentNullException.ThrowIfNull(assignment);

        if (Exists(assignment.TeacherId, assignment.DepartmentId, assignment.SubjectId))
        {
            throw new InvalidOperationException("Такой допуск преподавателя уже существует.");
        }

        assignments.Add(assignment);
    }
}
