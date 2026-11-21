using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Forms;

public partial class GradeListForm : Form
{
    private readonly IGradeRepository gradeRepository;
    private readonly IStudentRepository studentRepository;
    private readonly ITeachingAssignmentRepository assignmentRepository;
    private readonly ITeacherRepository teacherRepository;
    private readonly IDepartmentRepository departmentRepository;
    private readonly ISubjectRepository subjectRepository;

    public GradeListForm(
        IGradeRepository gradeRepository,
        IStudentRepository studentRepository,
        ITeachingAssignmentRepository assignmentRepository,
        ITeacherRepository teacherRepository,
        IDepartmentRepository departmentRepository,
        ISubjectRepository subjectRepository)
    {
        InitializeComponent();
        this.gradeRepository = gradeRepository;
        this.studentRepository = studentRepository;
        this.assignmentRepository = assignmentRepository;
        this.teacherRepository = teacherRepository;
        this.departmentRepository = departmentRepository;
        this.subjectRepository = subjectRepository;
        LoadGrades();
    }

    private void LoadGrades()
    {
        Dictionary<int, string> studentNames = studentRepository.GetAll()
            .ToDictionary(student => student.Id, student => student.FullName);
        Dictionary<int, string> teacherNames = teacherRepository.GetAll()
            .ToDictionary(teacher => teacher.Id, teacher => teacher.FullName);
        Dictionary<int, string> subjectNames = subjectRepository.GetAll()
            .ToDictionary(subject => subject.Id, subject => subject.Name);

        gradesGridView.Rows.Clear();
        foreach (Grade grade in gradeRepository.GetAll())
        {
            gradesGridView.Rows.Add(
                NameLookup.Find(studentNames, grade.StudentId),
                NameLookup.Find(subjectNames, grade.SubjectId),
                NameLookup.Find(teacherNames, grade.TeacherId),
                grade.Semester,
                EnumDescriptionProvider.GetDescription(grade.AssessmentType),
                grade.ExamDate.ToString("dd.MM.yyyy"),
                grade.Mark);
        }
    }

    private void addButton_Click(object? sender, EventArgs e)
    {
        using GradeAddForm addForm = new(
            gradeRepository,
            studentRepository,
            assignmentRepository,
            teacherRepository,
            departmentRepository,
            subjectRepository);

        if (addForm.ShowDialog(this) == DialogResult.OK)
        {
            LoadGrades();
        }
    }
}
