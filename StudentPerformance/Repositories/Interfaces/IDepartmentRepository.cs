using StudentPerformance.Models;

namespace StudentPerformance.Repositories.Interfaces;

public interface IDepartmentRepository
{
    IReadOnlyList<Department> GetAll();

    Department? GetById(int id);

    void Add(Department department);

    void Update(Department department);

    void Delete(int id);
}
