using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Forms;

public partial class TeachingAssignmentListForm : Form
{
    private readonly ITeachingAssignmentRepository assignmentRepository;
    private readonly ITeacherRepository teacherRepository;
    private readonly IDepartmentRepository departmentRepository;
    private readonly ISubjectRepository subjectRepository;

    public TeachingAssignmentListForm(
        ITeachingAssignmentRepository assignmentRepository,
        ITeacherRepository teacherRepository,
        IDepartmentRepository departmentRepository,
        ISubjectRepository subjectRepository)
    {
        InitializeComponent();
        this.assignmentRepository = assignmentRepository;
        this.teacherRepository = teacherRepository;
        this.departmentRepository = departmentRepository;
        this.subjectRepository = subjectRepository;
        LoadAssignments();
    }

    private void LoadAssignments()
    {
        Dictionary<int, string> teacherNames = teacherRepository.GetAll()
            .ToDictionary(teacher => teacher.Id, teacher => teacher.FullName);
        Dictionary<int, string> departmentNames = departmentRepository.GetAll()
            .ToDictionary(department => department.Id, department => department.Name);
        Dictionary<int, string> subjectNames = subjectRepository.GetAll()
            .ToDictionary(subject => subject.Id, subject => subject.Name);

        assignmentsGridView.Rows.Clear();
        foreach (TeachingAssignment assignment in assignmentRepository.GetAll())
        {
            assignmentsGridView.Rows.Add(
                NameLookup.Find(teacherNames, assignment.TeacherId),
                NameLookup.Find(departmentNames, assignment.DepartmentId),
                NameLookup.Find(subjectNames, assignment.SubjectId),
                EnumDescriptionProvider.GetDescription(assignment.LessonTypes));
        }
    }

    private void addButton_Click(object? sender, EventArgs e)
    {
        using TeachingAssignmentAddForm addForm = new(
            assignmentRepository,
            teacherRepository,
            departmentRepository,
            subjectRepository);

        if (addForm.ShowDialog(this) == DialogResult.OK)
        {
            LoadAssignments();
        }
    }
}
