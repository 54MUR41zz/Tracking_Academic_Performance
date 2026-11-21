#nullable disable

namespace StudentPerformance.Forms;

partial class SubjectEditForm
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
        this.hoursLabel = new Label();
        this.hoursNumericUpDown = new NumericUpDown();
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
        // hoursLabel
        //
        this.hoursLabel.AutoSize = true;
        this.hoursLabel.Location = new Point(12, 54);
        this.hoursLabel.Size = new Size(119, 15);
        this.hoursLabel.Text = "Количество часов:";
        this.hoursLabel.Name = "hoursLabel";
        this.hoursLabel.TabIndex = 2;
        //
        // hoursNumericUpDown
        //
        this.hoursNumericUpDown.Location = new Point(150, 51);
        this.hoursNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        this.hoursNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.hoursNumericUpDown.Size = new Size(120, 23);
        this.hoursNumericUpDown.Value = new decimal(new int[] { 36, 0, 0, 0 });
        this.hoursNumericUpDown.Name = "hoursNumericUpDown";
        this.hoursNumericUpDown.TabIndex = 3;
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
        // SubjectEditForm
        //
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(420, 137);
        this.Controls.Add(this.nameLabel);
        this.Controls.Add(this.nameTextBox);
        this.Controls.Add(this.hoursLabel);
        this.Controls.Add(this.hoursNumericUpDown);
        this.Controls.Add(this.saveButton);
        this.Controls.Add(this.cancelButton);
        this.AcceptButton = this.saveButton;
        this.CancelButton = this.cancelButton;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.ShowInTaskbar = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Дисциплина";
        this.Name = "SubjectEditForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label nameLabel;
    private TextBox nameTextBox;
    private Label hoursLabel;
    private NumericUpDown hoursNumericUpDown;
    private Button saveButton;
    private Button cancelButton;
}
