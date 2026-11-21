using StudentPerformance.Validation;

namespace StudentPerformance.Models;

public sealed class Department
{
    private Department(int id, int deaneryId, string name)
    {
        Id = id;
        DeaneryId = deaneryId;
        Name = name;
    }

    public int Id { get; private set; }
    public int DeaneryId { get; private set; }
    public string Name { get; private set; }

    public static Department Create(int id, int deaneryId, string? name)
    {
        return new Department(
            Guard.NotNegative(id, "Идентификатор"),
            Guard.RequiredReference(deaneryId, "Деканат"),
            Guard.NotBlank(name, "Наименование кафедры"));
    }
}
