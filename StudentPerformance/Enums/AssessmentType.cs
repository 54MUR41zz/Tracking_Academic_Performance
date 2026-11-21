using System.ComponentModel;

namespace StudentPerformance.Enums;

public enum AssessmentType
{
    [Description("Экзамен")]
    Exam = 1,

    [Description("Зачёт")]
    Credit = 2,

    [Description("Курсовая работа")]
    CourseWork = 3
}
