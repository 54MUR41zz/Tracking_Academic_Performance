using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Forms;

public partial class TeacherEditForm : Form
{
    private readonly ITeacherRepository teacherRepository;
    private readonly int teacherId;

    public TeacherEditForm(ITeacherRepository teacherRepository, Teacher? teacher = null)
    {
        InitializeComponent();
        this.teacherRepository = teacherRepository;
        teacherId = teacher?.Id ?? 0;

        Text = teacher is null ? "Новый преподаватель" : "Редактирование преподавателя";
        if (teacher is not null)
        {
            fullNameTextBox.Text = teacher.FullName;
            positionTextBox.Text = teacher.Position;
        }
    }

    private void saveButton_Click(object? sender, EventArgs e)
    {
        try
        {
            Teacher teacher = Teacher.Create(teacherId, fullNameTextBox.Text, positionTextBox.Text);

            if (teacherId == 0)
            {
                teacherRepository.Add(teacher);
            }
            else
            {
                teacherRepository.Update(teacher);
            }

            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException exception)
        {
            MessageDialogs.ShowInputError(this, exception.Message);
        }
    }
}
