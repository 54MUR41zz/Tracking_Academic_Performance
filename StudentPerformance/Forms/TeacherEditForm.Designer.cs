#nullable disable

namespace StudentPerformance.Forms;

partial class TeacherEditForm
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
        this.fullNameLabel = new Label();
        this.fullNameTextBox = new TextBox();
        this.positionLabel = new Label();
        this.positionTextBox = new TextBox();
        this.saveButton = new Button();
        this.cancelButton = new Button();
        this.SuspendLayout();
        //
        // fullNameLabel
        //
        this.fullNameLabel.AutoSize = true;
        this.fullNameLabel.Location = new Point(12, 18);
        this.fullNameLabel.Size = new Size(28, 15);
        this.fullNameLabel.Text = "ФИО:";
        this.fullNameLabel.Name = "fullNameLabel";
        this.fullNameLabel.TabIndex = 0;
        //
        // fullNameTextBox
        //
        this.fullNameTextBox.Location = new Point(150, 15);
        this.fullNameTextBox.Size = new Size(250, 23);
        this.fullNameTextBox.Name = "fullNameTextBox";
        this.fullNameTextBox.TabIndex = 1;
        //
        // positionLabel
        //
        this.positionLabel.AutoSize = true;
        this.positionLabel.Location = new Point(12, 54);
        this.positionLabel.Size = new Size(70, 15);
        this.positionLabel.Text = "Должность:";
        this.positionLabel.Name = "positionLabel";
        this.positionLabel.TabIndex = 2;
        //
        // positionTextBox
        //
        this.positionTextBox.Location = new Point(150, 51);
        this.positionTextBox.Size = new Size(250, 23);
        this.positionTextBox.Name = "positionTextBox";
        this.positionTextBox.TabIndex = 3;
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
        // TeacherEditForm
        //
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(420, 137);
        this.Controls.Add(this.fullNameLabel);
        this.Controls.Add(this.fullNameTextBox);
        this.Controls.Add(this.positionLabel);
        this.Controls.Add(this.positionTextBox);
        this.Controls.Add(this.saveButton);
        this.Controls.Add(this.cancelButton);
        this.AcceptButton = this.saveButton;
        this.CancelButton = this.cancelButton;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.ShowInTaskbar = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Преподаватель";
        this.Name = "TeacherEditForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label fullNameLabel;
    private TextBox fullNameTextBox;
    private Label positionLabel;
    private TextBox positionTextBox;
    private Button saveButton;
    private Button cancelButton;
}
