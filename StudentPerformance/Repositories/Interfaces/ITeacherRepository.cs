using StudentPerformance.Models;

namespace StudentPerformance.Repositories.Interfaces;

public interface ITeacherRepository
{
    IReadOnlyList<Teacher> GetAll();

    Teacher? GetById(int id);

    void Add(Teacher teacher);

    void Update(Teacher teacher);

    void Delete(int id);
}
