using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Forms;

public partial class TeacherListForm : Form
{
    private readonly ITeacherRepository teacherRepository;

    public TeacherListForm(ITeacherRepository teacherRepository)
    {
        InitializeComponent();
        this.teacherRepository = teacherRepository;
        LoadTeachers();
    }

    private void LoadTeachers()
    {
        teachersGridView.Rows.Clear();
        foreach (Teacher teacher in teacherRepository.GetAll())
        {
            int rowIndex = teachersGridView.Rows.Add(teacher.FullName, teacher.Position);
            teachersGridView.Rows[rowIndex].Tag = teacher;
        }
    }

    private Teacher? GetSelectedTeacher()
    {
        return teachersGridView.CurrentRow?.Tag as Teacher;
    }

    private void EditSelectedTeacher()
    {
        Teacher? selectedTeacher = GetSelectedTeacher();
        if (selectedTeacher is null)
        {
            MessageDialogs.ShowRowNotSelected(this);
            return;
        }

        using TeacherEditForm editForm = new(teacherRepository, selectedTeacher);
        if (editForm.ShowDialog(this) == DialogResult.OK)
        {
            LoadTeachers();
        }
    }

    private void addButton_Click(object? sender, EventArgs e)
    {
        using TeacherEditForm editForm = new(teacherRepository);
        if (editForm.ShowDialog(this) == DialogResult.OK)
        {
            LoadTeachers();
        }
    }

    private void editButton_Click(object? sender, EventArgs e)
    {
        EditSelectedTeacher();
    }

    private void deleteButton_Click(object? sender, EventArgs e)
    {
        Teacher? selectedTeacher = GetSelectedTeacher();
        if (selectedTeacher is null)
        {
            MessageDialogs.ShowRowNotSelected(this);
            return;
        }

        if (MessageDialogs.ConfirmDeletion(this, selectedTeacher.FullName))
        {
            teacherRepository.Delete(selectedTeacher.Id);
            LoadTeachers();
        }
    }

    private void teachersGridView_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            EditSelectedTeacher();
        }
    }
}
