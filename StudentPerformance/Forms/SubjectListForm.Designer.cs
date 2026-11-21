#nullable disable

namespace StudentPerformance.Forms;

partial class SubjectListForm
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
        this.subjectsGridView = new DataGridView();
        this.addButton = new Button();
        this.editButton = new Button();
        this.deleteButton = new Button();
        this.closeButton = new Button();
        this.nameColumn = new DataGridViewTextBoxColumn();
        this.hoursColumn = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.subjectsGridView)).BeginInit();
        this.SuspendLayout();
        //
        // subjectsGridView
        //
        this.subjectsGridView.AllowUserToAddRows = false;
        this.subjectsGridView.AllowUserToDeleteRows = false;
        this.subjectsGridView.AllowUserToResizeRows = false;
        this.subjectsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.subjectsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.subjectsGridView.Location = new Point(12, 12);
        this.subjectsGridView.MultiSelect = false;
        this.subjectsGridView.ReadOnly = true;
        this.subjectsGridView.RowHeadersVisible = false;
        this.subjectsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.subjectsGridView.Size = new Size(616, 328);
        this.subjectsGridView.Columns.AddRange(new DataGridViewColumn[] { this.nameColumn, this.hoursColumn });
        this.subjectsGridView.Name = "subjectsGridView";
        this.subjectsGridView.TabIndex = 0;
        this.subjectsGridView.CellDoubleClick += new DataGridViewCellEventHandler(this.subjectsGridView_CellDoubleClick);
        //
        // addButton
        //
        this.addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        this.addButton.Location = new Point(12, 352);
        this.addButton.Size = new Size(110, 32);
        this.addButton.Text = "Добавить";
        this.addButton.UseVisualStyleBackColor = true;
        this.addButton.Name = "addButton";
        this.addButton.TabIndex = 1;
        this.addButton.Click += new EventHandler(this.addButton_Click);
        //
        // editButton
        //
        this.editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        this.editButton.Location = new Point(132, 352);
        this.editButton.Size = new Size(110, 32);
        this.editButton.Text = "Изменить";
        this.editButton.UseVisualStyleBackColor = true;
        this.editButton.Name = "editButton";
        this.editButton.TabIndex = 2;
        this.editButton.Click += new EventHandler(this.editButton_Click);
        //
        // deleteButton
        //
        this.deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        this.deleteButton.Location = new Point(252, 352);
        this.deleteButton.Size = new Size(110, 32);
        this.deleteButton.Text = "Удалить";
        this.deleteButton.UseVisualStyleBackColor = true;
        this.deleteButton.Name = "deleteButton";
        this.deleteButton.TabIndex = 3;
        this.deleteButton.Click += new EventHandler(this.deleteButton_Click);
        //
        // closeButton
        //
        this.closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.closeButton.Location = new Point(518, 352);
        this.closeButton.Size = new Size(110, 32);
        this.closeButton.Text = "Закрыть";
        this.closeButton.DialogResult = DialogResult.Cancel;
        this.closeButton.UseVisualStyleBackColor = true;
        this.closeButton.Name = "closeButton";
        this.closeButton.TabIndex = 4;
        //
        // nameColumn
        //
        this.nameColumn.HeaderText = "Наименование";
        this.nameColumn.Name = "nameColumn";
        this.nameColumn.ReadOnly = true;
        //
        // hoursColumn
        //
        this.hoursColumn.HeaderText = "Часов";
        this.hoursColumn.Name = "hoursColumn";
        this.hoursColumn.ReadOnly = true;
        //
        // SubjectListForm
        //
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(640, 400);
        this.Controls.Add(this.subjectsGridView);
        this.Controls.Add(this.addButton);
        this.Controls.Add(this.editButton);
        this.Controls.Add(this.deleteButton);
        this.Controls.Add(this.closeButton);
        this.CancelButton = this.closeButton;
        this.MinimumSize = new Size(560, 320);
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Дисциплины";
        this.Name = "SubjectListForm";
        ((System.ComponentModel.ISupportInitialize)(this.subjectsGridView)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private DataGridView subjectsGridView;
    private Button addButton;
    private Button editButton;
    private Button deleteButton;
    private Button closeButton;
    private DataGridViewTextBoxColumn nameColumn;
    private DataGridViewTextBoxColumn hoursColumn;
}
