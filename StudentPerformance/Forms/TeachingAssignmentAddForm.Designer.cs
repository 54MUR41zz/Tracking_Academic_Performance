#nullable disable

namespace StudentPerformance.Forms;

partial class TeachingAssignmentAddForm
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
        this.teacherLabel = new Label();
        this.teacherComboBox = new ComboBox();
        this.departmentLabel = new Label();
        this.departmentComboBox = new ComboBox();
        this.subjectLabel = new Label();
        this.subjectComboBox = new ComboBox();
        this.lessonTypesLabel = new Label();
        this.lectureCheckBox = new CheckBox();
        this.practiceCheckBox = new CheckBox();
        this.laboratoryCheckBox = new CheckBox();
        this.saveButton = new Button();
        this.cancelButton = new Button();
        this.SuspendLayout();
        //
        // teacherLabel
        //
        this.teacherLabel.AutoSize = true;
        this.teacherLabel.Location = new Point(12, 18);
        this.teacherLabel.Size = new Size(98, 15);
        this.teacherLabel.Text = "Преподаватель:";
        this.teacherLabel.Name = "teacherLabel";
        this.teacherLabel.TabIndex = 0;
        //
        // teacherComboBox
        //
        this.teacherComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.teacherComboBox.FormattingEnabled = true;
        this.teacherComboBox.Location = new Point(150, 15);
        this.teacherComboBox.Size = new Size(250, 23);
        this.teacherComboBox.Name = "teacherComboBox";
        this.teacherComboBox.TabIndex = 1;
        //
        // departmentLabel
        //
        this.departmentLabel.AutoSize = true;
        this.departmentLabel.Location = new Point(12, 54);
        this.departmentLabel.Size = new Size(56, 15);
        this.departmentLabel.Text = "Кафедра:";
        this.departmentLabel.Name = "departmentLabel";
        this.departmentLabel.TabIndex = 2;
        //
        // departmentComboBox
        //
        this.departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.departmentComboBox.FormattingEnabled = true;
        this.departmentComboBox.Location = new Point(150, 51);
        this.departmentComboBox.Size = new Size(250, 23);
        this.departmentComboBox.Name = "departmentComboBox";
        this.departmentComboBox.TabIndex = 3;
        //
        // subjectLabel
        //
        this.subjectLabel.AutoSize = true;
        this.subjectLabel.Location = new Point(12, 90);
        this.subjectLabel.Size = new Size(77, 15);
        this.subjectLabel.Text = "Дисциплина:";
        this.subjectLabel.Name = "subjectLabel";
        this.subjectLabel.TabIndex = 4;
        //
        // subjectComboBox
        //
        this.subjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.subjectComboBox.FormattingEnabled = true;
        this.subjectComboBox.Location = new Point(150, 87);
        this.subjectComboBox.Size = new Size(250, 23);
        this.subjectComboBox.Name = "subjectComboBox";
        this.subjectComboBox.TabIndex = 5;
        //
        // lessonTypesLabel
        //
        this.lessonTypesLabel.AutoSize = true;
        this.lessonTypesLabel.Location = new Point(12, 126);
        this.lessonTypesLabel.Size = new Size(91, 15);
        this.lessonTypesLabel.Text = "Виды занятий:";
        this.lessonTypesLabel.Name = "lessonTypesLabel";
        this.lessonTypesLabel.TabIndex = 6;
        //
        // lectureCheckBox
        //
        this.lectureCheckBox.AutoSize = true;
        this.lectureCheckBox.Location = new Point(150, 123);
        this.lectureCheckBox.Size = new Size(66, 19);
        this.lectureCheckBox.Text = "Лекции";
        this.lectureCheckBox.UseVisualStyleBackColor = true;
        this.lectureCheckBox.Name = "lectureCheckBox";
        this.lectureCheckBox.TabIndex = 7;
        //
        // practiceCheckBox
        //
        this.practiceCheckBox.AutoSize = true;
        this.practiceCheckBox.Location = new Point(150, 149);
        this.practiceCheckBox.Size = new Size(164, 19);
        this.practiceCheckBox.Text = "Практические занятия";
        this.practiceCheckBox.UseVisualStyleBackColor = true;
        this.practiceCheckBox.Name = "practiceCheckBox";
        this.practiceCheckBox.TabIndex = 8;
        //
        // laboratoryCheckBox
        //
        this.laboratoryCheckBox.AutoSize = true;
        this.laboratoryCheckBox.Location = new Point(150, 175);
        this.laboratoryCheckBox.Size = new Size(157, 19);
        this.laboratoryCheckBox.Text = "Лабораторные работы";
        this.laboratoryCheckBox.UseVisualStyleBackColor = true;
        this.laboratoryCheckBox.Name = "laboratoryCheckBox";
        this.laboratoryCheckBox.TabIndex = 9;
        //
        // saveButton
        //
        this.saveButton.Location = new Point(216, 211);
        this.saveButton.Size = new Size(90, 32);
        this.saveButton.Text = "Сохранить";
        this.saveButton.UseVisualStyleBackColor = true;
        this.saveButton.Name = "saveButton";
        this.saveButton.TabIndex = 10;
        this.saveButton.Click += new EventHandler(this.saveButton_Click);
        //
        // cancelButton
        //
        this.cancelButton.Location = new Point(312, 211);
        this.cancelButton.Size = new Size(90, 32);
        this.cancelButton.Text = "Отмена";
        this.cancelButton.DialogResult = DialogResult.Cancel;
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.TabIndex = 11;
        //
        // TeachingAssignmentAddForm
        //
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(420, 255);
        this.Controls.Add(this.teacherLabel);
        this.Controls.Add(this.teacherComboBox);
        this.Controls.Add(this.departmentLabel);
        this.Controls.Add(this.departmentComboBox);
        this.Controls.Add(this.subjectLabel);
        this.Controls.Add(this.subjectComboBox);
        this.Controls.Add(this.lessonTypesLabel);
        this.Controls.Add(this.lectureCheckBox);
        this.Controls.Add(this.practiceCheckBox);
        this.Controls.Add(this.laboratoryCheckBox);
        this.Controls.Add(this.saveButton);
        this.Controls.Add(this.cancelButton);
        this.AcceptButton = this.saveButton;
        this.CancelButton = this.cancelButton;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.ShowInTaskbar = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Новый допуск преподавателя";
        this.Name = "TeachingAssignmentAddForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label teacherLabel;
    private ComboBox teacherComboBox;
    private Label departmentLabel;
    private ComboBox departmentComboBox;
    private Label subjectLabel;
    private ComboBox subjectComboBox;
    private Label lessonTypesLabel;
    private CheckBox lectureCheckBox;
    private CheckBox practiceCheckBox;
    private CheckBox laboratoryCheckBox;
    private Button saveButton;
    private Button cancelButton;
}
