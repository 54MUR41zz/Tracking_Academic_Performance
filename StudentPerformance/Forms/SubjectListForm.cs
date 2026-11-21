using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Forms;

public partial class SubjectListForm : Form
{
    private readonly ISubjectRepository subjectRepository;

    public SubjectListForm(ISubjectRepository subjectRepository)
    {
        InitializeComponent();
        this.subjectRepository = subjectRepository;
        LoadSubjects();
    }

    private void LoadSubjects()
    {
        subjectsGridView.Rows.Clear();
        foreach (Subject subject in subjectRepository.GetAll())
        {
            int rowIndex = subjectsGridView.Rows.Add(subject.Name, subject.Hours);
            subjectsGridView.Rows[rowIndex].Tag = subject;
        }
    }

    private Subject? GetSelectedSubject()
    {
        return subjectsGridView.CurrentRow?.Tag as Subject;
    }

    private void EditSelectedSubject()
    {
        Subject? selectedSubject = GetSelectedSubject();
        if (selectedSubject is null)
        {
            MessageDialogs.ShowRowNotSelected(this);
            return;
        }

        using SubjectEditForm editForm = new(subjectRepository, selectedSubject);
        if (editForm.ShowDialog(this) == DialogResult.OK)
        {
            LoadSubjects();
        }
    }

    private void addButton_Click(object? sender, EventArgs e)
    {
        using SubjectEditForm editForm = new(subjectRepository);
        if (editForm.ShowDialog(this) == DialogResult.OK)
        {
            LoadSubjects();
        }
    }

    private void editButton_Click(object? sender, EventArgs e)
    {
        EditSelectedSubject();
    }

    private void deleteButton_Click(object? sender, EventArgs e)
    {
        Subject? selectedSubject = GetSelectedSubject();
        if (selectedSubject is null)
        {
            MessageDialogs.ShowRowNotSelected(this);
            return;
        }

        if (MessageDialogs.ConfirmDeletion(this, selectedSubject.Name))
        {
            subjectRepository.Delete(selectedSubject.Id);
            LoadSubjects();
        }
    }

    private void subjectsGridView_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            EditSelectedSubject();
        }
    }
}
