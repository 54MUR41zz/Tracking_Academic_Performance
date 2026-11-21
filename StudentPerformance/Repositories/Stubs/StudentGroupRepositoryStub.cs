using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Repositories.Stubs;

public sealed class StudentGroupRepositoryStub : IStudentGroupRepository
{
    private readonly List<StudentGroup> groups =
    [
        StudentGroup.Create(1, 1, "ПИ-241"),
        StudentGroup.Create(2, 1, "ПИ-242"),
        StudentGroup.Create(3, 2, "МА-251")
    ];

    public IReadOnlyList<StudentGroup> GetAll()
    {
        return groups.ToList();
    }

    public StudentGroup? GetById(int id)
    {
        return groups.FirstOrDefault(item => item.Id == id);
    }
}
