using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;
using StudentPerformance.Validation;

namespace StudentPerformance.Forms;

public partial class DepartmentEditForm : Form
{
    private readonly IDepartmentRepository departmentRepository;
    private readonly int departmentId;

    public DepartmentEditForm(
        IDepartmentRepository departmentRepository,
        IDeaneryRepository deaneryRepository,
        Department? department = null)
    {
        InitializeComponent();
        this.departmentRepository = departmentRepository;
        departmentId = department?.Id ?? 0;

        List<Deanery> deaneries = deaneryRepository.GetAll().ToList();
        deaneryComboBox.DataSource = deaneries;
        deaneryComboBox.DisplayMember = nameof(Deanery.Name);
        deaneryComboBox.SelectedIndex = -1;

        Text = department is null ? "Новая кафедра" : "Редактирование кафедры";
        if (department is not null)
        {
            nameTextBox.Text = department.Name;
            deaneryComboBox.SelectedItem = deaneries.FirstOrDefault(deanery => deanery.Id == department.DeaneryId);
        }
    }

    private void saveButton_Click(object? sender, EventArgs e)
    {
        try
        {
            Deanery? selectedDeanery = deaneryComboBox.SelectedItem as Deanery;
            Department department = Department.Create(
                departmentId,
                Guard.NotNull(selectedDeanery, "Деканат").Id,
                nameTextBox.Text);

            if (departmentId == 0)
            {
                departmentRepository.Add(department);
            }
            else
            {
                departmentRepository.Update(department);
            }

            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException exception)
        {
            MessageDialogs.ShowInputError(this, exception.Message);
        }
    }
}
