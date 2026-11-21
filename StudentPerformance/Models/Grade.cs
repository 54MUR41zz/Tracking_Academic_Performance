using StudentPerformance.Enums;
using StudentPerformance.Validation;

namespace StudentPerformance.Models;

public sealed class Grade
{
    private const int MinMark = 0;
    private const int MaxMark = 100;
    private static readonly DateTime MinExamDate = new(2000, 1, 1);

    private Grade(
        int id,
        int studentId,
        int teacherId,
        int departmentId,
        int subjectId,
        string semester,
        AssessmentType assessmentType,
        DateTime examDate,
        int mark)
    {
        Id = id;
        StudentId = studentId;
        TeacherId = teacherId;
        DepartmentId = departmentId;
        SubjectId = subjectId;
        Semester = semester;
        AssessmentType = assessmentType;
        ExamDate = examDate;
        Mark = mark;
    }

    public int Id { get; private set; }

    public int StudentId { get; private set; }

    public int TeacherId { get; private set; }

    public int DepartmentId { get; private set; }

    public int SubjectId { get; private set; }

    public string Semester { get; private set; }

    public AssessmentType AssessmentType { get; private set; }

    public DateTime ExamDate { get; private set; }

    public int Mark { get; private set; }

    public static Grade Create(
        int id,
        int studentId,
        int teacherId,
        int departmentId,
        int subjectId,
        string? semester,
        AssessmentType assessmentType,
        DateTime examDate,
        int mark)
    {
        return new Grade(
            Guard.NotNegative(id, "Идентификатор"),
            Guard.RequiredReference(studentId, "Студент"),
            Guard.RequiredReference(teacherId, "Преподаватель"),
            Guard.RequiredReference(departmentId, "Кафедра"),
            Guard.RequiredReference(subjectId, "Дисциплина"),
            Guard.NotBlank(semester, "Семестр"),
            Guard.Defined(assessmentType, "Форма контроля"),
            Guard.DateInRange(examDate, MinExamDate, DateTime.Today, "Дата сдачи"),
            Guard.InRange(mark, MinMark, MaxMark, "Балл"));
    }
}
