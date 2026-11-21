using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Repositories.Stubs;

public sealed class StudentRepositoryStub : IStudentRepository
{
    private readonly List<Student> students =
    [
        Student.Create(1, 1, "Иванов Иван Иванович", new DateTime(2006, 3, 14)),
        Student.Create(2, 1, "Петрова Мария Сергеевна", new DateTime(2006, 7, 2)),
        Student.Create(3, 2, "Сидоров Алексей Петрович", new DateTime(2005, 11, 25)),
        Student.Create(4, 3, "Кузнецова Анна Дмитриевна", new DateTime(2007, 1, 9))
    ];

    public IReadOnlyList<Student> GetAll()
    {
        return students.ToList();
    }

    public Student? GetById(int id)
    {
        return students.FirstOrDefault(item => item.Id == id);
    }
}
