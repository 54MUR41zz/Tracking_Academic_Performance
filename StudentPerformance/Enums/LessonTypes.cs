using System.ComponentModel;

namespace StudentPerformance.Enums;

[Flags]
public enum LessonTypes
{
    [Description("Не указано")]
    None = 0,

    [Description("Лекции")]
    Lecture = 1,

    [Description("Практические занятия")]
    Practice = 2,

    [Description("Лабораторные работы")]
    Laboratory = 4
}
