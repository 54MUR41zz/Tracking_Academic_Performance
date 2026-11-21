using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Repositories.Stubs;

public sealed class StudyStreamRepositoryStub : IStudyStreamRepository
{
    private readonly List<StudyStream> streams =
    [
        StudyStream.Create(1, 1, 2024),
        StudyStream.Create(2, 3, 2025)
    ];

    public IReadOnlyList<StudyStream> GetAll()
    {
        return streams.ToList();
    }

    public StudyStream? GetById(int id)
    {
        return streams.FirstOrDefault(item => item.Id == id);
    }
}
