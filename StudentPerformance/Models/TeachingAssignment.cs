using StudentPerformance.Enums;
using StudentPerformance.Validation;

namespace StudentPerformance.Models;

public sealed class TeachingAssignment
{
    private const LessonTypes AllLessonTypes = LessonTypes.Lecture | LessonTypes.Practice | LessonTypes.Laboratory;

    private TeachingAssignment(int teacherId, int departmentId, int subjectId, LessonTypes lessonTypes)
    {
        TeacherId = teacherId;
        DepartmentId = departmentId;
        SubjectId = subjectId;
        LessonTypes = lessonTypes;
    }

    public int TeacherId { get; private set; }

    public int DepartmentId { get; private set; }

    public int SubjectId { get; private set; }

    public LessonTypes LessonTypes { get; private set; }

    public static TeachingAssignment Create(int teacherId, int departmentId, int subjectId, LessonTypes lessonTypes)
    {
        if (lessonTypes == LessonTypes.None)
        {
            throw new ArgumentException("Не выбран ни один вид занятий.");
        }

        if ((lessonTypes & ~AllLessonTypes) != 0)
        {
            throw new ArgumentException("Указан недопустимый вид занятий.");
        }

        return new TeachingAssignment(
            Guard.RequiredReference(teacherId, "Преподаватель"),
            Guard.RequiredReference(departmentId, "Кафедра"),
            Guard.RequiredReference(subjectId, "Дисциплина"),
            lessonTypes);
    }
}
