using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Repositories.Stubs;

public sealed class SubjectRepositoryStub : ISubjectRepository
{
    private readonly List<Subject> subjects =
    [
        Subject.Create(1, "Программирование", 144),
        Subject.Create(2, "Базы данных", 108),
        Subject.Create(3, "Математический анализ", 180)
    ];

    private int lastId = 3;

    public IReadOnlyList<Subject> GetAll()
    {
        return subjects.ToList();
    }

    public Subject? GetById(int id)
    {
        return subjects.FirstOrDefault(item => item.Id == id);
    }

    public void Add(Subject subject)
    {
        ArgumentNullException.ThrowIfNull(subject);

        lastId++;
        subjects.Add(Subject.Create(lastId, subject.Name, subject.Hours));
    }

    public void Update(Subject subject)
    {
        ArgumentNullException.ThrowIfNull(subject);

        int index = subjects.FindIndex(item => item.Id == subject.Id);
        if (index < 0)
        {
            throw new InvalidOperationException($"Дисциплина с идентификатором {subject.Id} не найдена.");
        }

        subjects[index] = subject;
    }

    public void Delete(int id)
    {
        subjects.RemoveAll(item => item.Id == id);
    }
}
