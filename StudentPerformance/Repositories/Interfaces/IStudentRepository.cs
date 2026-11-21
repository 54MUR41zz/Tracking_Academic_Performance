using StudentPerformance.Models;

namespace StudentPerformance.Repositories.Interfaces;

public interface IStudentRepository
{
    IReadOnlyList<Student> GetAll();

    Student? GetById(int id);
}
