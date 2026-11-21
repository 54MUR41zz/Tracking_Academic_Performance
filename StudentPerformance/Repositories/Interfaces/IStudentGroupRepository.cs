using StudentPerformance.Models;

namespace StudentPerformance.Repositories.Interfaces;

public interface IStudentGroupRepository
{
    IReadOnlyList<StudentGroup> GetAll();

    StudentGroup? GetById(int id);
}
