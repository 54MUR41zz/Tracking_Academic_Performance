#nullable disable

namespace StudentPerformance.Forms;

partial class GradeAddForm
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
        this.studentLabel = new Label();
        this.studentComboBox = new ComboBox();
        this.assignmentLabel = new Label();
        this.assignmentComboBox = new ComboBox();
        this.semesterLabel = new Label();
        this.semesterTextBox = new TextBox();
        this.assessmentTypeLabel = new Label();
        this.assessmentTypeComboBox = new ComboBox();
        this.examDateLabel = new Label();
        this.examDatePicker = new DateTimePicker();
        this.markLabel = new Label();
        this.markNumericUpDown = new NumericUpDown();
        this.saveButton = new Button();
        this.cancelButton = new Button();
        this.SuspendLayout();
        //
        // studentLabel
        //
        this.studentLabel.AutoSize = true;
        this.studentLabel.Location = new Point(12, 18);
        this.studentLabel.Size = new Size(56, 15);
        this.studentLabel.Text = "Студент:";
        this.studentLabel.Name = "studentLabel";
        this.studentLabel.TabIndex = 0;
        //
        // studentComboBox
        //
        this.studentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.studentComboBox.FormattingEnabled = true;
        this.studentComboBox.Location = new Point(170, 15);
        this.studentComboBox.Size = new Size(380, 23);
        this.studentComboBox.Name = "studentComboBox";
        this.studentComboBox.TabIndex = 1;
        //
        // assignmentLabel
        //
        this.assignmentLabel.AutoSize = true;
        this.assignmentLabel.Location = new Point(12, 54);
        this.assignmentLabel.Size = new Size(147, 15);
        this.assignmentLabel.Text = "Допуск преподавателя:";
        this.assignmentLabel.Name = "assignmentLabel";
        this.assignmentLabel.TabIndex = 2;
        //
        // assignmentComboBox
        //
        this.assignmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.assignmentComboBox.FormattingEnabled = true;
        this.assignmentComboBox.Location = new Point(170, 51);
        this.assignmentComboBox.Size = new Size(380, 23);
        this.assignmentComboBox.DropDownWidth = 520;
        this.assignmentComboBox.Name = "assignmentComboBox";
        this.assignmentComboBox.TabIndex = 3;
        //
        // semesterLabel
        //
        this.semesterLabel.AutoSize = true;
        this.semesterLabel.Location = new Point(12, 90);
        this.semesterLabel.Size = new Size(56, 15);
        this.semesterLabel.Text = "Семестр:";
        this.semesterLabel.Name = "semesterLabel";
        this.semesterLabel.TabIndex = 4;
        //
        // semesterTextBox
        //
        this.semesterTextBox.Location = new Point(170, 87);
        this.semesterTextBox.Size = new Size(380, 23);
        this.semesterTextBox.PlaceholderText = "2025/2026 осенний";
        this.semesterTextBox.Name = "semesterTextBox";
        this.semesterTextBox.TabIndex = 5;
        //
        // assessmentTypeLabel
        //
        this.assessmentTypeLabel.AutoSize = true;
        this.assessmentTypeLabel.Location = new Point(12, 126);
        this.assessmentTypeLabel.Size = new Size(105, 15);
        this.assessmentTypeLabel.Text = "Форма контроля:";
        this.assessmentTypeLabel.Name = "assessmentTypeLabel";
        this.assessmentTypeLabel.TabIndex = 6;
        //
        // assessmentTypeComboBox
        //
        this.assessmentTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.assessmentTypeComboBox.FormattingEnabled = true;
        this.assessmentTypeComboBox.Location = new Point(170, 123);
        this.assessmentTypeComboBox.Size = new Size(380, 23);
        this.assessmentTypeComboBox.Name = "assessmentTypeComboBox";
        this.assessmentTypeComboBox.TabIndex = 7;
        //
        // examDateLabel
        //
        this.examDateLabel.AutoSize = true;
        this.examDateLabel.Location = new Point(12, 162);
        this.examDateLabel.Size = new Size(77, 15);
        this.examDateLabel.Text = "Дата сдачи:";
        this.examDateLabel.Name = "examDateLabel";
        this.examDateLabel.TabIndex = 8;
        //
        // examDatePicker
        //
        this.examDatePicker.Format = DateTimePickerFormat.Short;
        this.examDatePicker.Location = new Point(170, 159);
        this.examDatePicker.Size = new Size(120, 23);
        this.examDatePicker.Name = "examDatePicker";
        this.examDatePicker.TabIndex = 9;
        //
        // markLabel
        //
        this.markLabel.AutoSize = true;
        this.markLabel.Location = new Point(12, 198);
        this.markLabel.Size = new Size(91, 15);
        this.markLabel.Text = "Балл (0–100):";
        this.markLabel.Name = "markLabel";
        this.markLabel.TabIndex = 10;
        //
        // markNumericUpDown
        //
        this.markNumericUpDown.Location = new Point(170, 195);
        this.markNumericUpDown.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        this.markNumericUpDown.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        this.markNumericUpDown.Size = new Size(120, 23);
        this.markNumericUpDown.Value = new decimal(new int[] { 0, 0, 0, 0 });
        this.markNumericUpDown.Name = "markNumericUpDown";
        this.markNumericUpDown.TabIndex = 11;
        //
        // saveButton
        //
        this.saveButton.Location = new Point(376, 237);
        this.saveButton.Size = new Size(90, 32);
        this.saveButton.Text = "Сохранить";
        this.saveButton.UseVisualStyleBackColor = true;
        this.saveButton.Name = "saveButton";
        this.saveButton.TabIndex = 12;
        this.saveButton.Click += new EventHandler(this.saveButton_Click);
        //
        // cancelButton
        //
        this.cancelButton.Location = new Point(472, 237);
        this.cancelButton.Size = new Size(90, 32);
        this.cancelButton.Text = "Отмена";
        this.cancelButton.DialogResult = DialogResult.Cancel;
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.TabIndex = 13;
        //
        // GradeAddForm
        //
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(580, 281);
        this.Controls.Add(this.studentLabel);
        this.Controls.Add(this.studentComboBox);
        this.Controls.Add(this.assignmentLabel);
        this.Controls.Add(this.assignmentComboBox);
        this.Controls.Add(this.semesterLabel);
        this.Controls.Add(this.semesterTextBox);
        this.Controls.Add(this.assessmentTypeLabel);
        this.Controls.Add(this.assessmentTypeComboBox);
        this.Controls.Add(this.examDateLabel);
        this.Controls.Add(this.examDatePicker);
        this.Controls.Add(this.markLabel);
        this.Controls.Add(this.markNumericUpDown);
        this.Controls.Add(this.saveButton);
        this.Controls.Add(this.cancelButton);
        this.AcceptButton = this.saveButton;
        this.CancelButton = this.cancelButton;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.ShowInTaskbar = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Новая оценка";
        this.Name = "GradeAddForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label studentLabel;
    private ComboBox studentComboBox;
    private Label assignmentLabel;
    private ComboBox assignmentComboBox;
    private Label semesterLabel;
    private TextBox semesterTextBox;
    private Label assessmentTypeLabel;
    private ComboBox assessmentTypeComboBox;
    private Label examDateLabel;
    private DateTimePicker examDatePicker;
    private Label markLabel;
    private NumericUpDown markNumericUpDown;
    private Button saveButton;
    private Button cancelButton;
}
