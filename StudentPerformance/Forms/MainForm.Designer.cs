#nullable disable

namespace StudentPerformance.Forms;

partial class MainForm
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
        this.mainMenuStrip = new MenuStrip();
        this.referencesMenuItem = new ToolStripMenuItem();
        this.departmentsMenuItem = new ToolStripMenuItem();
        this.subjectsMenuItem = new ToolStripMenuItem();
        this.teachersMenuItem = new ToolStripMenuItem();
        this.operationsMenuItem = new ToolStripMenuItem();
        this.teachingAssignmentsMenuItem = new ToolStripMenuItem();
        this.gradesMenuItem = new ToolStripMenuItem();
        this.reportsMenuItem = new ToolStripMenuItem();
        this.welcomeLabel = new Label();
        this.mainMenuStrip.SuspendLayout();
        this.SuspendLayout();
        //
        // mainMenuStrip
        //
        this.mainMenuStrip.Items.AddRange(new ToolStripItem[] { this.referencesMenuItem, this.operationsMenuItem, this.reportsMenuItem });
        this.mainMenuStrip.Location = new Point(0, 0);
        this.mainMenuStrip.Name = "mainMenuStrip";
        this.mainMenuStrip.Size = new Size(900, 24);
        this.mainMenuStrip.TabIndex = 0;
        //
        // referencesMenuItem
        //
        this.referencesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.departmentsMenuItem, this.subjectsMenuItem, this.teachersMenuItem });
        this.referencesMenuItem.Name = "referencesMenuItem";
        this.referencesMenuItem.Text = "Справочники";
        //
        // departmentsMenuItem
        //
        this.departmentsMenuItem.Name = "departmentsMenuItem";
        this.departmentsMenuItem.Text = "Кафедры";
        this.departmentsMenuItem.Click += new EventHandler(this.departmentsMenuItem_Click);
        //
        // subjectsMenuItem
        //
        this.subjectsMenuItem.Name = "subjectsMenuItem";
        this.subjectsMenuItem.Text = "Дисциплины";
        this.subjectsMenuItem.Click += new EventHandler(this.subjectsMenuItem_Click);
        //
        // teachersMenuItem
        //
        this.teachersMenuItem.Name = "teachersMenuItem";
        this.teachersMenuItem.Text = "Преподаватели";
        this.teachersMenuItem.Click += new EventHandler(this.teachersMenuItem_Click);
        //
        // operationsMenuItem
        //
        this.operationsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.teachingAssignmentsMenuItem, this.gradesMenuItem });
        this.operationsMenuItem.Name = "operationsMenuItem";
        this.operationsMenuItem.Text = "Операции";
        //
        // teachingAssignmentsMenuItem
        //
        this.teachingAssignmentsMenuItem.Name = "teachingAssignmentsMenuItem";
        this.teachingAssignmentsMenuItem.Text = "Допуски преподавателей";
        this.teachingAssignmentsMenuItem.Click += new EventHandler(this.teachingAssignmentsMenuItem_Click);
        //
        // gradesMenuItem
        //
        this.gradesMenuItem.Name = "gradesMenuItem";
        this.gradesMenuItem.Text = "Успеваемость";
        this.gradesMenuItem.Click += new EventHandler(this.gradesMenuItem_Click);
        //
        // reportsMenuItem
        //
        this.reportsMenuItem.Name = "reportsMenuItem";
        this.reportsMenuItem.Text = "Отчёты";
        //
        // welcomeLabel
        //
        this.welcomeLabel.Dock = DockStyle.Fill;
        this.welcomeLabel.Font = new Font("Segoe UI", 16F);
        this.welcomeLabel.Location = new Point(0, 24);
        this.welcomeLabel.Name = "welcomeLabel";
        this.welcomeLabel.Size = new Size(900, 516);
        this.welcomeLabel.TabIndex = 1;
        this.welcomeLabel.Text = "Учёт успеваемости студентов в деканатах университета";
        this.welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
        //
        // MainForm
        //
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(900, 540);
        this.Controls.Add(this.welcomeLabel);
        this.Controls.Add(this.mainMenuStrip);
        this.MainMenuStrip = this.mainMenuStrip;
        this.MinimumSize = new Size(640, 400);
        this.Name = "MainForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Учёт успеваемости студентов";
        this.mainMenuStrip.ResumeLayout(false);
        this.mainMenuStrip.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private MenuStrip mainMenuStrip;
    private ToolStripMenuItem referencesMenuItem;
    private ToolStripMenuItem departmentsMenuItem;
    private ToolStripMenuItem subjectsMenuItem;
    private ToolStripMenuItem teachersMenuItem;
    private ToolStripMenuItem operationsMenuItem;
    private ToolStripMenuItem teachingAssignmentsMenuItem;
    private ToolStripMenuItem gradesMenuItem;
    private ToolStripMenuItem reportsMenuItem;
    private Label welcomeLabel;
}
