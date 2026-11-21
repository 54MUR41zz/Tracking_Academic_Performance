using StudentPerformance.Models;

namespace StudentPerformance.Repositories.Interfaces;

public interface IStudyStreamRepository
{
    IReadOnlyList<StudyStream> GetAll();

    StudyStream? GetById(int id);
}
