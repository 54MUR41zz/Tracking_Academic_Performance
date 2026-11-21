namespace StudentPerformance.Forms;

public partial class MainForm : Form
{
    private readonly Func<DepartmentListForm> departmentListFormFactory;
    private readonly Func<SubjectListForm> subjectListFormFactory;
    private readonly Func<TeacherListForm> teacherListFormFactory;
    private readonly Func<TeachingAssignmentListForm> teachingAssignmentListFormFactory;
    private readonly Func<GradeListForm> gradeListFormFactory;

    public MainForm(
        Func<DepartmentListForm> departmentListFormFactory,
        Func<SubjectListForm> subjectListFormFactory,
        Func<TeacherListForm> teacherListFormFactory,
        Func<TeachingAssignmentListForm> teachingAssignmentListFormFactory,
        Func<GradeListForm> gradeListFormFactory)
    {
        InitializeComponent();
        this.departmentListFormFactory = departmentListFormFactory;
        this.subjectListFormFactory = subjectListFormFactory;
        this.teacherListFormFactory = teacherListFormFactory;
        this.teachingAssignmentListFormFactory = teachingAssignmentListFormFactory;
        this.gradeListFormFactory = gradeListFormFactory;
    }

    private void ShowListForm<TForm>(Func<TForm> formFactory) where TForm : Form
    {
        using TForm listForm = formFactory();
        listForm.ShowDialog(this);
    }

    private void departmentsMenuItem_Click(object? sender, EventArgs e)
    {
        ShowListForm(departmentListFormFactory);
    }

    private void subjectsMenuItem_Click(object? sender, EventArgs e)
    {
        ShowListForm(subjectListFormFactory);
    }

    private void teachersMenuItem_Click(object? sender, EventArgs e)
    {
        ShowListForm(teacherListFormFactory);
    }

    private void teachingAssignmentsMenuItem_Click(object? sender, EventArgs e)
    {
        ShowListForm(teachingAssignmentListFormFactory);
    }

    private void gradesMenuItem_Click(object? sender, EventArgs e)
    {
        ShowListForm(gradeListFormFactory);
    }
}
