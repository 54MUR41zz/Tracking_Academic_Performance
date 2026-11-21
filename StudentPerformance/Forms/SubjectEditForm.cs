using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Forms;

public partial class SubjectEditForm : Form
{
    private readonly ISubjectRepository subjectRepository;
    private readonly int subjectId;

    public SubjectEditForm(ISubjectRepository subjectRepository, Subject? subject = null)
    {
        InitializeComponent();
        this.subjectRepository = subjectRepository;
        subjectId = subject?.Id ?? 0;

        Text = subject is null ? "Новая дисциплина" : "Редактирование дисциплины";
        if (subject is not null)
        {
            nameTextBox.Text = subject.Name;
            hoursNumericUpDown.Value = subject.Hours;
        }
    }

    private void saveButton_Click(object? sender, EventArgs e)
    {
        try
        {
            Subject subject = Subject.Create(subjectId, nameTextBox.Text, (int)hoursNumericUpDown.Value);

            if (subjectId == 0)
            {
                subjectRepository.Add(subject);
            }
            else
            {
                subjectRepository.Update(subject);
            }

            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException exception)
        {
            MessageDialogs.ShowInputError(this, exception.Message);
        }
    }
}
