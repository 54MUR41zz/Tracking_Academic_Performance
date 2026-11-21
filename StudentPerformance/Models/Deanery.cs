using StudentPerformance.Validation;

namespace StudentPerformance.Models;

public sealed class Deanery
{
    private Deanery(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }

    public static Deanery Create(int id, string? name)
    {
        return new Deanery(
            Guard.NotNegative(id, "Идентификатор"),
            Guard.NotBlank(name, "Наименование деканата"));
    }
}
