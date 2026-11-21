namespace StudentPerformance.Validation;

public static class Guard
{
    public static T NotNull<T>(T? value, string fieldTitle) where T : class
    {
        if (value is null)
        {
            throw new ArgumentNullException(null, $"Не указано значение: «{fieldTitle}».");
        }

        return value;
    }

    public static string NotBlank(string? value, string fieldTitle)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"Поле «{fieldTitle}» не заполнено.");
        }

        return value.Trim();
    }

    public static int NotNegative(int value, string fieldTitle)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Поле «{fieldTitle}» не может быть отрицательным.");
        }

        return value;
    }

    public static int RequiredReference(int value, string fieldTitle)
    {
        if (value <= 0)
        {
            throw new ArgumentException($"Не выбрана связанная запись: «{fieldTitle}».");
        }

        return value;
    }

    public static int InRange(int value, int minimum, int maximum, string fieldTitle)
    {
        if (value < minimum || value > maximum)
        {
            throw new ArgumentException(
                $"Значение поля «{fieldTitle}» должно быть в диапазоне от {minimum} до {maximum}.");
        }

        return value;
    }

    public static DateTime DateInRange(DateTime value, DateTime minimum, DateTime maximum, string fieldTitle)
    {
        if (value < minimum || value > maximum)
        {
            throw new ArgumentException(
                $"Дата в поле «{fieldTitle}» должна быть в диапазоне от {minimum:dd.MM.yyyy} до {maximum:dd.MM.yyyy}.");
        }

        return value;
    }

    public static TEnum Defined<TEnum>(TEnum value, string fieldTitle) where TEnum : struct, Enum
    {
        if (!Enum.IsDefined(value))
        {
            throw new ArgumentException($"Недопустимое значение поля «{fieldTitle}».");
        }

        return value;
    }
}
