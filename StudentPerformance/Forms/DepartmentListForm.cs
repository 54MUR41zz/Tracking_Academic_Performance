using StudentPerformance.Infrastructure;
using StudentPerformance.Models;
using StudentPerformance.Repositories.Interfaces;

namespace StudentPerformance.Forms;

public partial class DepartmentListForm : Form
{
    private readonly IDepartmentRepository departmentRepository;
    private readonly IDeaneryRepository deaneryRepository;

    public DepartmentListForm(IDepartmentRepository departmentRepository, IDeaneryRepository deaneryRepository)
    {
        InitializeComponent();
        this.departmentRepository = departmentRepository;
        this.deaneryRepository = deaneryRepository;
        LoadDepartments();
    }

    private void LoadDepartments()
    {
        Dictionary<int, string> deaneryNames = deaneryRepository.GetAll()
            .ToDictionary(deanery => deanery.Id, deanery => deanery.Name);

        departmentsGridView.Rows.Clear();
        foreach (Department department in departmentRepository.GetAll())
        {
            int rowIndex = departmentsGridView.Rows.Add(
                department.Name,
                NameLookup.Find(deaneryNames, department.DeaneryId));
            departmentsGridView.Rows[rowIndex].Tag = department;
        }
    }

    private Department? GetSelectedDepartment()
    {
        return departmentsGridView.CurrentRow?.Tag as Department;
    }

    private void EditSelectedDepartment()
    {
        Department? selectedDepartment = GetSelectedDepartment();
        if (selectedDepartment is null)
        {
            MessageDialogs.ShowRowNotSelected(this);
            return;
        }

        using DepartmentEditForm editForm = new(departmentRepository, deaneryRepository, selectedDepartment);
        if (editForm.ShowDialog(this) == DialogResult.OK)
        {
            LoadDepartments();
        }
    }

    private void addButton_Click(object? sender, EventArgs e)
    {
        using DepartmentEditForm editForm = new(departmentRepository, deaneryRepository);
        if (editForm.ShowDialog(this) == DialogResult.OK)
        {
            LoadDepartments();
        }
    }

    private void editButton_Click(object? sender, EventArgs e)
    {
        EditSelectedDepartment();
    }

    private void deleteButton_Click(object? sender, EventArgs e)
    {
        Department? selectedDepartment = GetSelectedDepartment();
        if (selectedDepartment is null)
        {
            MessageDialogs.ShowRowNotSelected(this);
            return;
        }

        if (MessageDialogs.ConfirmDeletion(this, selectedDepartment.Name))
        {
            departmentRepository.Delete(selectedDepartment.Id);
            LoadDepartments();
        }
    }

    private void departmentsGridView_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            EditSelectedDepartment();
        }
    }
}
