using StudentPerformance.Enums;
using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;
using StudentPerformance.Validation;

namespace StudentPerformance.Forms;

public partial class TeachingAssignmentAddForm : Form
{
    private readonly ITeachingAssignmentRepository assignmentRepository;

    public TeachingAssignmentAddForm(
        ITeachingAssignmentRepository assignmentRepository,
        ITeacherRepository teacherRepository,
        IDepartmentRepository departmentRepository,
        ISubjectRepository subjectRepository)
    {
        InitializeComponent();
        this.assignmentRepository = assignmentRepository;
        LoadComboBox(teacherComboBox, teacherRepository.GetAll(), nameof(Teacher.FullName));
        LoadComboBox(departmentComboBox, departmentRepository.GetAll(), nameof(Department.Name));
        LoadComboBox(subjectComboBox, subjectRepository.GetAll(), nameof(Subject.Name));
    }

    private static void LoadComboBox<TItem>(ComboBox comboBox, IEnumerable<TItem> items, string displayMember)
    {
        comboBox.DataSource = items.ToList();
        comboBox.DisplayMember = displayMember;
        comboBox.SelectedIndex = -1;
    }

    private LessonTypes GetSelectedLessonTypes()
    {
        LessonTypes lessonTypes = LessonTypes.None;

        if (lectureCheckBox.Checked)
        {
            lessonTypes |= LessonTypes.Lecture;
        }

        if (practiceCheckBox.Checked)
        {
            lessonTypes |= LessonTypes.Practice;
        }

        if (laboratoryCheckBox.Checked)
        {
            lessonTypes |= LessonTypes.Laboratory;
        }

        return lessonTypes;
    }

    private void saveButton_Click(object? sender, EventArgs e)
    {
        try
        {
            Teacher? selectedTeacher = teacherComboBox.SelectedItem as Teacher;
            Department? selectedDepartment = departmentComboBox.SelectedItem as Department;
            Subject? selectedSubject = subjectComboBox.SelectedItem as Subject;

            TeachingAssignment assignment = TeachingAssignment.Create(
                Guard.NotNull(selectedTeacher, "Преподаватель").Id,
                Guard.NotNull(selectedDepartment, "Кафедра").Id,
                Guard.NotNull(selectedSubject, "Дисциплина").Id,
                GetSelectedLessonTypes());

            if (assignmentRepository.Exists(assignment.TeacherId, assignment.DepartmentId, assignment.SubjectId))
            {
                MessageDialogs.ShowInputError(
                    this,
                    "Этот преподаватель уже допущен к выбранной дисциплине на данной кафедре.");
                return;
            }

            assignmentRepository.Add(assignment);
            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException exception)
        {
            MessageDialogs.ShowInputError(this, exception.Message);
        }
    }
}
