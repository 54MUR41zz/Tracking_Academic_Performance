using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Repositories.Stubs;

public sealed class DeaneryRepositoryStub : IDeaneryRepository
{
    private readonly List<Deanery> deaneries =
    [
        Deanery.Create(1, "Деканат факультета информационных технологий"),
        Deanery.Create(2, "Деканат физико-математического факультета")
    ];

    public IReadOnlyList<Deanery> GetAll()
    {
        return deaneries.ToList();
    }

    public Deanery? GetById(int id)
    {
        return deaneries.FirstOrDefault(item => item.Id == id);
    }
}
