namespace ElectiveSubjectsAdminTool
{
  partial class FormConfigurateSubjects
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      TableLayoutPanelMain = new TableLayoutPanel();
      TableLayoutPanelStudents = new TableLayoutPanel();
      DataGridViewStudents = new DataGridView();
      TableLayoutPanelStudentButtons = new TableLayoutPanel();
      ButtonAddStudent = new Button();
      ButtonRemoveStudent = new Button();
      TableLayoutPanelSubjects = new TableLayoutPanel();
      DataGridViewSubjects = new DataGridView();
      TableLayoutPanelSubjectButtons = new TableLayoutPanel();
      ButtonAddSubject = new Button();
      ButtonRemoveSubject = new Button();
      TableLayoutPanelMain.SuspendLayout();
      TableLayoutPanelStudents.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)DataGridViewStudents).BeginInit();
      TableLayoutPanelStudentButtons.SuspendLayout();
      TableLayoutPanelSubjects.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)DataGridViewSubjects).BeginInit();
      TableLayoutPanelSubjectButtons.SuspendLayout();
      SuspendLayout();
      // 
      // TableLayoutPanelMain
      // 
      TableLayoutPanelMain.ColumnCount = 2;
      TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      TableLayoutPanelMain.Controls.Add(TableLayoutPanelSubjects, 1, 0);
      TableLayoutPanelMain.Controls.Add(TableLayoutPanelStudents, 0, 0);
      TableLayoutPanelMain.Dock = DockStyle.Fill;
      TableLayoutPanelMain.Location = new Point(0, 0);
      TableLayoutPanelMain.Name = "TableLayoutPanelMain";
      TableLayoutPanelMain.RowCount = 1;
      TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelMain.Size = new Size(948, 547);
      TableLayoutPanelMain.TabIndex = 0;
      // 
      // TableLayoutPanelStudents
      // 
      TableLayoutPanelStudents.ColumnCount = 2;
      TableLayoutPanelStudents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.07623F));
      TableLayoutPanelStudents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9237671F));
      TableLayoutPanelStudents.Controls.Add(DataGridViewStudents, 0, 0);
      TableLayoutPanelStudents.Controls.Add(TableLayoutPanelStudentButtons, 1, 0);
      TableLayoutPanelStudents.Dock = DockStyle.Fill;
      TableLayoutPanelStudents.Location = new Point(3, 3);
      TableLayoutPanelStudents.Name = "TableLayoutPanelStudents";
      TableLayoutPanelStudents.RowCount = 1;
      TableLayoutPanelStudents.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelStudents.Size = new Size(468, 541);
      TableLayoutPanelStudents.TabIndex = 0;
      // 
      // DataGridViewStudents
      // 
      DataGridViewStudents.AllowUserToAddRows = false;
      DataGridViewStudents.AllowUserToDeleteRows = false;
      DataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      DataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      DataGridViewStudents.Dock = DockStyle.Fill;
      DataGridViewStudents.Location = new Point(3, 3);
      DataGridViewStudents.Name = "DataGridViewStudents";
      DataGridViewStudents.ReadOnly = true;
      DataGridViewStudents.RowHeadersVisible = false;
      DataGridViewStudents.RowHeadersWidth = 51;
      DataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      DataGridViewStudents.Size = new Size(326, 535);
      DataGridViewStudents.TabIndex = 2;
      // 
      // TableLayoutPanelStudentButtons
      // 
      TableLayoutPanelStudentButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TableLayoutPanelStudentButtons.ColumnCount = 1;
      TableLayoutPanelStudentButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      TableLayoutPanelStudentButtons.Controls.Add(ButtonAddStudent, 0, 0);
      TableLayoutPanelStudentButtons.Controls.Add(ButtonRemoveStudent, 0, 1);
      TableLayoutPanelStudentButtons.Location = new Point(335, 3);
      TableLayoutPanelStudentButtons.Name = "TableLayoutPanelStudentButtons";
      TableLayoutPanelStudentButtons.RowCount = 2;
      TableLayoutPanelStudentButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelStudentButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelStudentButtons.Size = new Size(130, 125);
      TableLayoutPanelStudentButtons.TabIndex = 3;
      // 
      // ButtonAddStudent
      // 
      ButtonAddStudent.Dock = DockStyle.Fill;
      ButtonAddStudent.Location = new Point(3, 3);
      ButtonAddStudent.Name = "ButtonAddStudent";
      ButtonAddStudent.Size = new Size(124, 56);
      ButtonAddStudent.TabIndex = 0;
      ButtonAddStudent.Text = "Schüler hinzufügen";
      ButtonAddStudent.UseVisualStyleBackColor = true;
      // 
      // ButtonRemoveStudent
      // 
      ButtonRemoveStudent.Dock = DockStyle.Fill;
      ButtonRemoveStudent.Location = new Point(3, 65);
      ButtonRemoveStudent.Name = "ButtonRemoveStudent";
      ButtonRemoveStudent.Size = new Size(124, 57);
      ButtonRemoveStudent.TabIndex = 1;
      ButtonRemoveStudent.Text = "Schüler entfernen";
      ButtonRemoveStudent.UseVisualStyleBackColor = true;
      // 
      // TableLayoutPanelSubjects
      // 
      TableLayoutPanelSubjects.ColumnCount = 2;
      TableLayoutPanelSubjects.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.07623F));
      TableLayoutPanelSubjects.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9237671F));
      TableLayoutPanelSubjects.Controls.Add(DataGridViewSubjects, 0, 0);
      TableLayoutPanelSubjects.Controls.Add(TableLayoutPanelSubjectButtons, 1, 0);
      TableLayoutPanelSubjects.Dock = DockStyle.Fill;
      TableLayoutPanelSubjects.Location = new Point(477, 3);
      TableLayoutPanelSubjects.Name = "TableLayoutPanelSubjects";
      TableLayoutPanelSubjects.RowCount = 1;
      TableLayoutPanelSubjects.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelSubjects.Size = new Size(468, 541);
      TableLayoutPanelSubjects.TabIndex = 1;
      // 
      // DataGridViewSubjects
      // 
      DataGridViewSubjects.AllowUserToAddRows = false;
      DataGridViewSubjects.AllowUserToDeleteRows = false;
      DataGridViewSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      DataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      DataGridViewSubjects.Dock = DockStyle.Fill;
      DataGridViewSubjects.Location = new Point(3, 3);
      DataGridViewSubjects.Name = "DataGridViewSubjects";
      DataGridViewSubjects.ReadOnly = true;
      DataGridViewSubjects.RowHeadersVisible = false;
      DataGridViewSubjects.RowHeadersWidth = 51;
      DataGridViewSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      DataGridViewSubjects.Size = new Size(326, 535);
      DataGridViewSubjects.TabIndex = 2;
      // 
      // TableLayoutPanelSubjectButtons
      // 
      TableLayoutPanelSubjectButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TableLayoutPanelSubjectButtons.ColumnCount = 1;
      TableLayoutPanelSubjectButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      TableLayoutPanelSubjectButtons.Controls.Add(ButtonAddSubject, 0, 0);
      TableLayoutPanelSubjectButtons.Controls.Add(ButtonRemoveSubject, 0, 1);
      TableLayoutPanelSubjectButtons.Location = new Point(335, 3);
      TableLayoutPanelSubjectButtons.Name = "TableLayoutPanelSubjectButtons";
      TableLayoutPanelSubjectButtons.RowCount = 2;
      TableLayoutPanelSubjectButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelSubjectButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelSubjectButtons.Size = new Size(130, 125);
      TableLayoutPanelSubjectButtons.TabIndex = 3;
      // 
      // ButtonAddSubject
      // 
      ButtonAddSubject.Dock = DockStyle.Fill;
      ButtonAddSubject.Location = new Point(3, 3);
      ButtonAddSubject.Name = "ButtonAddSubject";
      ButtonAddSubject.Size = new Size(124, 56);
      ButtonAddSubject.TabIndex = 0;
      ButtonAddSubject.Text = "Wahlpflichtfach hinzufügen";
      ButtonAddSubject.UseVisualStyleBackColor = true;
      // 
      // ButtonRemoveSubject
      // 
      ButtonRemoveSubject.Dock = DockStyle.Fill;
      ButtonRemoveSubject.Location = new Point(3, 65);
      ButtonRemoveSubject.Name = "ButtonRemoveSubject";
      ButtonRemoveSubject.Size = new Size(124, 57);
      ButtonRemoveSubject.TabIndex = 1;
      ButtonRemoveSubject.Text = "Wahlpflichtfach entfernen";
      ButtonRemoveSubject.UseVisualStyleBackColor = true;
      // 
      // FormConfigurateSubjects
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(948, 547);
      Controls.Add(TableLayoutPanelMain);
      Name = "FormConfigurateSubjects";
      Text = "Vorbereitung der Fächer und Schüler";
      TableLayoutPanelMain.ResumeLayout(false);
      TableLayoutPanelStudents.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)DataGridViewStudents).EndInit();
      TableLayoutPanelStudentButtons.ResumeLayout(false);
      TableLayoutPanelSubjects.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)DataGridViewSubjects).EndInit();
      TableLayoutPanelSubjectButtons.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel TableLayoutPanelMain;
    private TableLayoutPanel TableLayoutPanelStudents;
    private DataGridView DataGridViewStudents;
    private TableLayoutPanel TableLayoutPanelStudentButtons;
    private Button ButtonAddStudent;
    private Button ButtonRemoveStudent;
    private TableLayoutPanel TableLayoutPanelSubjects;
    private DataGridView DataGridViewSubjects;
    private TableLayoutPanel TableLayoutPanelSubjectButtons;
    private Button ButtonAddSubject;
    private Button ButtonRemoveSubject;
  }
}