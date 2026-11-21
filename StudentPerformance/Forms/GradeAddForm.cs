using StudentPerformance.Enums;
using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;
using StudentPerformance.Validation;

namespace StudentPerformance.Forms;

public partial class GradeAddForm : Form
{
    private readonly IGradeRepository gradeRepository;

    public GradeAddForm(
        IGradeRepository gradeRepository,
        IStudentRepository studentRepository,
        ITeachingAssignmentRepository assignmentRepository,
        ITeacherRepository teacherRepository,
        IDepartmentRepository departmentRepository,
        ISubjectRepository subjectRepository)
    {
        InitializeComponent();
        this.gradeRepository = gradeRepository;
        LoadStudents(studentRepository.GetAll());
        LoadAssignments(
            assignmentRepository.GetAll(),
            teacherRepository.GetAll(),
            departmentRepository.GetAll(),
            subjectRepository.GetAll());
        LoadAssessmentTypes();
    }

    private void LoadStudents(IEnumerable<Student> students)
    {
        studentComboBox.DataSource = students.ToList();
        studentComboBox.DisplayMember = nameof(Student.FullName);
        studentComboBox.SelectedIndex = -1;
    }

    private void LoadAssignments(
        IEnumerable<TeachingAssignment> assignments,
        IEnumerable<Teacher> teachers,
        IEnumerable<Department> departments,
        IEnumerable<Subject> subjects)
    {
        Dictionary<int, string> teacherNames = teachers.ToDictionary(teacher => teacher.Id, teacher => teacher.FullName);
        Dictionary<int, string> departmentNames = departments.ToDictionary(department => department.Id, department => department.Name);
        Dictionary<int, string> subjectNames = subjects.ToDictionary(subject => subject.Id, subject => subject.Name);

        List<ComboBoxItem<TeachingAssignment>> items = assignments
            .Select(assignment => new ComboBoxItem<TeachingAssignment>(
                assignment,
                string.Join(
                    " — ",
                    NameLookup.Find(teacherNames, assignment.TeacherId),
                    NameLookup.Find(departmentNames, assignment.DepartmentId),
                    NameLookup.Find(subjectNames, assignment.SubjectId))))
            .ToList();

        assignmentComboBox.DataSource = items;
        assignmentComboBox.DisplayMember = nameof(ComboBoxItem<TeachingAssignment>.Title);
        assignmentComboBox.SelectedIndex = -1;
    }

    private void LoadAssessmentTypes()
    {
        List<ComboBoxItem<AssessmentType>> items = Enum.GetValues<AssessmentType>()
            .Select(assessmentType => new ComboBoxItem<AssessmentType>(
                assessmentType,
                EnumDescriptionProvider.GetDescription(assessmentType)))
            .ToList();

        assessmentTypeComboBox.DataSource = items;
        assessmentTypeComboBox.DisplayMember = nameof(ComboBoxItem<AssessmentType>.Title);
        assessmentTypeComboBox.SelectedIndex = 0;
    }

    private void saveButton_Click(object? sender, EventArgs e)
    {
        try
        {
            Student? selectedStudent = studentComboBox.SelectedItem as Student;
            ComboBoxItem<TeachingAssignment>? selectedAssignment =
                assignmentComboBox.SelectedItem as ComboBoxItem<TeachingAssignment>;
            ComboBoxItem<AssessmentType>? selectedAssessmentType =
                assessmentTypeComboBox.SelectedItem as ComboBoxItem<AssessmentType>;

            TeachingAssignment assignment = Guard.NotNull(selectedAssignment, "Допуск преподавателя").Value;

            Grade grade = Grade.Create(
                0,
                Guard.NotNull(selectedStudent, "Студент").Id,
                assignment.TeacherId,
                assignment.DepartmentId,
                assignment.SubjectId,
                semesterTextBox.Text,
                Guard.NotNull(selectedAssessmentType, "Форма контроля").Value,
                examDatePicker.Value.Date,
                (int)markNumericUpDown.Value);

            if (gradeRepository.Exists(grade.StudentId, grade.SubjectId, grade.Semester))
            {
                MessageDialogs.ShowInputError(
                    this,
                    "Оценка этого студента по выбранной дисциплине за указанный семестр уже выставлена.");
                return;
            }

            gradeRepository.Add(grade);
            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException exception)
        {
            MessageDialogs.ShowInputError(this, exception.Message);
        }
    }
}
