#nullable disable

namespace StudentPerformance.Forms;

partial class DepartmentEditForm
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
        this.nameLabel = new Label();
        this.nameTextBox = new TextBox();
        this.deaneryLabel = new Label();
        this.deaneryComboBox = new ComboBox();
        this.saveButton = new Button();
        this.cancelButton = new Button();
        this.SuspendLayout();
        //
        // nameLabel
        //
        this.nameLabel.AutoSize = true;
        this.nameLabel.Location = new Point(12, 18);
        this.nameLabel.Size = new Size(91, 15);
        this.nameLabel.Text = "Наименование:";
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.TabIndex = 0;
        //
        // nameTextBox
        //
        this.nameTextBox.Location = new Point(150, 15);
        this.nameTextBox.Size = new Size(250, 23);
        this.nameTextBox.Name = "nameTextBox";
        this.nameTextBox.TabIndex = 1;
        //
        // deaneryLabel
        //
        this.deaneryLabel.AutoSize = true;
        this.deaneryLabel.Location = new Point(12, 54);
        this.deaneryLabel.Size = new Size(56, 15);
        this.deaneryLabel.Text = "Деканат:";
        this.deaneryLabel.Name = "deaneryLabel";
        this.deaneryLabel.TabIndex = 2;
        //
        // deaneryComboBox
        //
        this.deaneryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.deaneryComboBox.FormattingEnabled = true;
        this.deaneryComboBox.Location = new Point(150, 51);
        this.deaneryComboBox.Size = new Size(250, 23);
        this.deaneryComboBox.Name = "deaneryComboBox";
        this.deaneryComboBox.TabIndex = 3;
        //
        // saveButton
        //
        this.saveButton.Location = new Point(216, 93);
        this.saveButton.Size = new Size(90, 32);
        this.saveButton.Text = "Сохранить";
        this.saveButton.UseVisualStyleBackColor = true;
        this.saveButton.Name = "saveButton";
        this.saveButton.TabIndex = 4;
        this.saveButton.Click += new EventHandler(this.saveButton_Click);
        //
        // cancelButton
        //
        this.cancelButton.Location = new Point(312, 93);
        this.cancelButton.Size = new Size(90, 32);
        this.cancelButton.Text = "Отмена";
        this.cancelButton.DialogResult = DialogResult.Cancel;
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.TabIndex = 5;
        //
        // DepartmentEditForm
        //
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(420, 137);
        this.Controls.Add(this.nameLabel);
        this.Controls.Add(this.nameTextBox);
        this.Controls.Add(this.deaneryLabel);
        this.Controls.Add(this.deaneryComboBox);
        this.Controls.Add(this.saveButton);
        this.Controls.Add(this.cancelButton);
        this.AcceptButton = this.saveButton;
        this.CancelButton = this.cancelButton;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.ShowInTaskbar = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Кафедра";
        this.Name = "DepartmentEditForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label nameLabel;
    private TextBox nameTextBox;
    private Label deaneryLabel;
    private ComboBox deaneryComboBox;
    private Button saveButton;
    private Button cancelButton;
}
