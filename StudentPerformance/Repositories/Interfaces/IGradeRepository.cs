using StudentPerformance.Models;

namespace StudentPerformance.Repositories.Interfaces;

public interface IGradeRepository
{
    IReadOnlyList<Grade> GetAll();

    bool Exists(int studentId, int subjectId, string semester);

    void Add(Grade grade);
}
