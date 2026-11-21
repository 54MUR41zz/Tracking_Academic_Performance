#nullable disable

namespace StudentPerformance.Forms;

partial class TeachingAssignmentListForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.assignmentsGridView = new DataGridView();
        this.addButton = new Button();
        this.closeButton = new Button();
        this.teacherColumn = new DataGridViewTextBoxColumn();
        this.departmentColumn = new DataGridViewTextBoxColumn();
        this.subjectColumn = new DataGridViewTextBoxColumn();
        this.lessonTypesColumn = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.assignmentsGridView)).BeginInit();
        this.SuspendLayout();
        //
        // assignmentsGridView
        //
        this.assignmentsGridView.AllowUserToAddRows = false;
        this.assignmentsGridView.AllowUserToDeleteRows = false;
        this.assignmentsGridView.AllowUserToResizeRows = false;
        this.assignmentsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.assignmentsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.assignmentsGridView.Location = new Point(12, 12);
        this.assignmentsGridView.MultiSelect = false;
        this.assignmentsGridView.ReadOnly = true;
        this.assignmentsGridView.RowHeadersVisible = false;
        this.assignmentsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.assignmentsGridView.Size = new Size(776, 348);
        this.assignmentsGridView.Columns.AddRange(new DataGridViewColumn[] { this.teacherColumn, this.departmentColumn, this.subjectColumn, this.lessonTypesColumn });
        this.assignmentsGridView.Name = "assignmentsGridView";
        this.assignmentsGridView.TabIndex = 0;
        //
        // addButton
        //
        this.addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        this.addButton.Location = new Point(12, 372);
        this.addButton.Size = new Size(110, 32);
        this.addButton.Text = "Добавить";
        this.addButton.UseVisualStyleBackColor = true;
        this.addButton.Name = "addButton";
        this.addButton.TabIndex = 1;
        this.addButton.Click += new EventHandler(this.addButton_Click);
        //
        // closeButton
        //
        this.closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.closeButton.Location = new Point(678, 372);
        this.closeButton.Size = new Size(110, 32);
        this.closeButton.Text = "Закрыть";
        this.closeButton.DialogResult = DialogResult.Cancel;
        this.closeButton.UseVisualStyleBackColor = true;
        this.closeButton.Name = "closeButton";
        this.closeButton.TabIndex = 2;
        //
        // teacherColumn
        //
        this.teacherColumn.HeaderText = "Преподаватель";
        this.teacherColumn.Name = "teacherColumn";
        this.teacherColumn.ReadOnly = true;
        //
        // departmentColumn
        //
        this.departmentColumn.HeaderText = "Кафедра";
        this.departmentColumn.Name = "departmentColumn";
        this.departmentColumn.ReadOnly = true;
        //
        // subjectColumn
        //
        this.subjectColumn.HeaderText = "Дисциплина";
        this.subjectColumn.Name = "subjectColumn";
        this.subjectColumn.ReadOnly = true;
        //
        // lessonTypesColumn
        //
        this.lessonTypesColumn.HeaderText = "Виды занятий";
        this.lessonTypesColumn.Name = "lessonTypesColumn";
        this.lessonTypesColumn.ReadOnly = true;
        //
        // TeachingAssignmentListForm
        //
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 420);
        this.Controls.Add(this.assignmentsGridView);
        this.Controls.Add(this.addButton);
        this.Controls.Add(this.closeButton);
        this.CancelButton = this.closeButton;
        this.MinimumSize = new Size(560, 320);
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Допуски преподавателей";
        this.Name = "TeachingAssignmentListForm";
        ((System.ComponentModel.ISupportInitialize)(this.assignmentsGridView)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private DataGridView assignmentsGridView;
    private Button addButton;
    private Button closeButton;
    private DataGridViewTextBoxColumn teacherColumn;
    private DataGridViewTextBoxColumn departmentColumn;
    private DataGridViewTextBoxColumn subjectColumn;
    private DataGridViewTextBoxColumn lessonTypesColumn;
}
