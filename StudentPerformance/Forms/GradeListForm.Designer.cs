#nullable disable

namespace StudentPerformance.Forms;

partial class GradeListForm
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
        this.gradesGridView = new DataGridView();
        this.addButton = new Button();
        this.closeButton = new Button();
        this.studentColumn = new DataGridViewTextBoxColumn();
        this.subjectColumn = new DataGridViewTextBoxColumn();
        this.teacherColumn = new DataGridViewTextBoxColumn();
        this.semesterColumn = new DataGridViewTextBoxColumn();
        this.assessmentTypeColumn = new DataGridViewTextBoxColumn();
        this.examDateColumn = new DataGridViewTextBoxColumn();
        this.markColumn = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.gradesGridView)).BeginInit();
        this.SuspendLayout();
        //
        // gradesGridView
        //
        this.gradesGridView.AllowUserToAddRows = false;
        this.gradesGridView.AllowUserToDeleteRows = false;
        this.gradesGridView.AllowUserToResizeRows = false;
        this.gradesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.gradesGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.gradesGridView.Location = new Point(12, 12);
        this.gradesGridView.MultiSelect = false;
        this.gradesGridView.ReadOnly = true;
        this.gradesGridView.RowHeadersVisible = false;
        this.gradesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.gradesGridView.Size = new Size(936, 388);
        this.gradesGridView.Columns.AddRange(new DataGridViewColumn[] { this.studentColumn, this.subjectColumn, this.teacherColumn, this.semesterColumn, this.assessmentTypeColumn, this.examDateColumn, this.markColumn });
        this.gradesGridView.Name = "gradesGridView";
        this.gradesGridView.TabIndex = 0;
        //
        // addButton
        //
        this.addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        this.addButton.Location = new Point(12, 412);
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
        this.closeButton.Location = new Point(838, 412);
        this.closeButton.Size = new Size(110, 32);
        this.closeButton.Text = "Закрыть";
        this.closeButton.DialogResult = DialogResult.Cancel;
        this.closeButton.UseVisualStyleBackColor = true;
        this.closeButton.Name = "closeButton";
        this.closeButton.TabIndex = 2;
        //
        // studentColumn
        //
        this.studentColumn.HeaderText = "Студент";
        this.studentColumn.Name = "studentColumn";
        this.studentColumn.ReadOnly = true;
        //
        // subjectColumn
        //
        this.subjectColumn.HeaderText = "Дисциплина";
        this.subjectColumn.Name = "subjectColumn";
        this.subjectColumn.ReadOnly = true;
        //
        // teacherColumn
        //
        this.teacherColumn.HeaderText = "Преподаватель";
        this.teacherColumn.Name = "teacherColumn";
        this.teacherColumn.ReadOnly = true;
        //
        // semesterColumn
        //
        this.semesterColumn.HeaderText = "Семестр";
        this.semesterColumn.Name = "semesterColumn";
        this.semesterColumn.ReadOnly = true;
        //
        // assessmentTypeColumn
        //
        this.assessmentTypeColumn.HeaderText = "Форма контроля";
        this.assessmentTypeColumn.Name = "assessmentTypeColumn";
        this.assessmentTypeColumn.ReadOnly = true;
        //
        // examDateColumn
        //
        this.examDateColumn.HeaderText = "Дата сдачи";
        this.examDateColumn.Name = "examDateColumn";
        this.examDateColumn.ReadOnly = true;
        //
        // markColumn
        //
        this.markColumn.HeaderText = "Балл";
        this.markColumn.Name = "markColumn";
        this.markColumn.ReadOnly = true;
        //
        // GradeListForm
        //
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(960, 460);
        this.Controls.Add(this.gradesGridView);
        this.Controls.Add(this.addButton);
        this.Controls.Add(this.closeButton);
        this.CancelButton = this.closeButton;
        this.MinimumSize = new Size(560, 320);
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Успеваемость студентов";
        this.Name = "GradeListForm";
        ((System.ComponentModel.ISupportInitialize)(this.gradesGridView)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private DataGridView gradesGridView;
    private Button addButton;
    private Button closeButton;
    private DataGridViewTextBoxColumn studentColumn;
    private DataGridViewTextBoxColumn subjectColumn;
    private DataGridViewTextBoxColumn teacherColumn;
    private DataGridViewTextBoxColumn semesterColumn;
    private DataGridViewTextBoxColumn assessmentTypeColumn;
    private DataGridViewTextBoxColumn examDateColumn;
    private DataGridViewTextBoxColumn markColumn;
}
