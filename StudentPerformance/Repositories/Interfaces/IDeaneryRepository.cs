using StudentPerformance.Models;

namespace StudentPerformance.Repositories.Interfaces;

public interface IDeaneryRepository
{
    IReadOnlyList<Deanery> GetAll();

    Deanery? GetById(int id);
}
