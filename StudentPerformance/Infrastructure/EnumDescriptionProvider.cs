using System.ComponentModel;
using System.Reflection;

namespace StudentPerformance.Infrastructure;

public static class EnumDescriptionProvider
{
    public static string GetDescription(Enum value)
    {
        Type enumType = value.GetType();
        bool isFlagsEnum = enumType.IsDefined(typeof(FlagsAttribute), false);

        if (!isFlagsEnum || Convert.ToInt64(value) == 0)
        {
            return GetMemberDescription(enumType, value);
        }

        IEnumerable<string> descriptions = Enum.GetValues(enumType)
            .Cast<Enum>()
            .Where(member => Convert.ToInt64(member) != 0 && value.HasFlag(member))
            .Select(member => GetMemberDescription(enumType, member));

        return string.Join(", ", descriptions);
    }

    private static string GetMemberDescription(Type enumType, Enum member)
    {
        string memberName = member.ToString();
        FieldInfo? field = enumType.GetField(memberName);
        DescriptionAttribute? attribute = field?.GetCustomAttribute<DescriptionAttribute>();

        return attribute?.Description ?? memberName;
    }
}
