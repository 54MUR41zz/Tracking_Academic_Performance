using StudentPerformance.Models;

namespace StudentPerformance.Repositories.Interfaces;

public interface ITeachingAssignmentRepository
{
    IReadOnlyList<TeachingAssignment> GetAll();

    bool Exists(int teacherId, int departmentId, int subjectId);

    void Add(TeachingAssignment assignment);
}
