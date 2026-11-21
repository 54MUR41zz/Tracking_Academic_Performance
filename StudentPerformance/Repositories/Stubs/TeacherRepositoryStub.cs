using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Repositories.Stubs;

public sealed class TeacherRepositoryStub : ITeacherRepository
{
    private readonly List<Teacher> teachers =
    [
        Teacher.Create(1, "Смирнов Олег Викторович", "Доцент"),
        Teacher.Create(2, "Орлова Елена Андреевна", "Профессор")
    ];

    private int lastId = 2;

    public IReadOnlyList<Teacher> GetAll()
    {
        return teachers.ToList();
    }

    public Teacher? GetById(int id)
    {
        return teachers.FirstOrDefault(item => item.Id == id);
    }

    public void Add(Teacher teacher)
    {
        ArgumentNullException.ThrowIfNull(teacher);

        lastId++;
        teachers.Add(Teacher.Create(lastId, teacher.FullName, teacher.Position));
    }

    public void Update(Teacher teacher)
    {
        ArgumentNullException.ThrowIfNull(teacher);

        int index = teachers.FindIndex(item => item.Id == teacher.Id);
        if (index < 0)
        {
            throw new InvalidOperationException($"Преподаватель с идентификатором {teacher.Id} не найден.");
        }

        teachers[index] = teacher;
    }

    public void Delete(int id)
    {
        teachers.RemoveAll(item => item.Id == id);
    }
}
