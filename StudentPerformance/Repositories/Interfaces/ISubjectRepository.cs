using StudentPerformance.Models;

namespace StudentPerformance.Repositories.Interfaces;

public interface ISubjectRepository
{
    IReadOnlyList<Subject> GetAll();

    Subject? GetById(int id);

    void Add(Subject subject);

    void Update(Subject subject);

    void Delete(int id);
}
