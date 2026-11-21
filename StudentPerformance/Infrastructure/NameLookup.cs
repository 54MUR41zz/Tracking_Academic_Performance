namespace StudentPerformance.Infrastructure;

public static class NameLookup
{
    private const string MissingName = "—";

    public static string Find(IReadOnlyDictionary<int, string> names, int id)
    {
        return names.GetValueOrDefault(id, MissingName);
    }
}
