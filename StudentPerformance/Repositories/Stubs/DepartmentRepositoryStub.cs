using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Repositories.Stubs;

public sealed class DepartmentRepositoryStub : IDepartmentRepository
{
    private readonly List<Department> departments =
    [
        Department.Create(1, 1, "Кафедра программной инженерии"),
        Department.Create(2, 1, "Кафедра информационных систем"),
        Department.Create(3, 2, "Кафедра высшей математики")
    ];

    private int lastId = 3;

    public IReadOnlyList<Department> GetAll()
    {
        return departments.ToList();
    }

    public Department? GetById(int id)
    {
        return departments.FirstOrDefault(item => item.Id == id);
    }

    public void Add(Department department)
    {
        ArgumentNullException.ThrowIfNull(department);

        lastId++;
        departments.Add(Department.Create(lastId, department.DeaneryId, department.Name));
    }

    public void Update(Department department)
    {
        ArgumentNullException.ThrowIfNull(department);

        int index = departments.FindIndex(item => item.Id == department.Id);
        if (index < 0)
        {
            throw new InvalidOperationException($"Кафедра с идентификатором {department.Id} не найдена.");
        }

        departments[index] = department;
    }

    public void Delete(int id)
    {
        departments.RemoveAll(item => item.Id == id);
    }
}
