namespace ElectiveSubjectsAdminTool
{
  partial class FormConfigurateTemplate
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
      TableLayoutPanelSubjects = new TableLayoutPanel();
      DataGridViewSubjects = new DataGridView();
      TableLayoutPanelSubjectButtons = new TableLayoutPanel();
      ButtonAddSubject = new Button();
      ButtonRemoveSubject = new Button();
      TableLayoutPanelStudents = new TableLayoutPanel();
      DataGridViewStudents = new DataGridView();
      TableLayoutPanelStudentButtons = new TableLayoutPanel();
      ButtonAddStudent = new Button();
      ButtonRemoveStudent = new Button();
      TableLayoutPanelGeneralButtons = new TableLayoutPanel();
      ButtonCreateTemplate = new Button();
      ButtonLoadSelectionResults = new Button();
      ButtonCancel = new Button();
      ButtonSaveSubjects = new Button();
      ButtonLoadSubjects = new Button();
      TableLayoutPanelMain.SuspendLayout();
      TableLayoutPanelSubjects.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)DataGridViewSubjects).BeginInit();
      TableLayoutPanelSubjectButtons.SuspendLayout();
      TableLayoutPanelStudents.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)DataGridViewStudents).BeginInit();
      TableLayoutPanelStudentButtons.SuspendLayout();
      TableLayoutPanelGeneralButtons.SuspendLayout();
      SuspendLayout();
      // 
      // TableLayoutPanelMain
      // 
      TableLayoutPanelMain.ColumnCount = 3;
      TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
      TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
      TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
      TableLayoutPanelMain.Controls.Add(TableLayoutPanelSubjects, 1, 0);
      TableLayoutPanelMain.Controls.Add(TableLayoutPanelStudents, 0, 0);
      TableLayoutPanelMain.Controls.Add(TableLayoutPanelGeneralButtons, 2, 0);
      TableLayoutPanelMain.Dock = DockStyle.Fill;
      TableLayoutPanelMain.Location = new Point(0, 0);
      TableLayoutPanelMain.Name = "TableLayoutPanelMain";
      TableLayoutPanelMain.RowCount = 1;
      TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      TableLayoutPanelMain.Size = new Size(1260, 594);
      TableLayoutPanelMain.TabIndex = 0;
      // 
      // TableLayoutPanelSubjects
      // 
      TableLayoutPanelSubjects.ColumnCount = 2;
      TableLayoutPanelSubjects.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.07623F));
      TableLayoutPanelSubjects.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9237671F));
      TableLayoutPanelSubjects.Controls.Add(DataGridViewSubjects, 0, 0);
      TableLayoutPanelSubjects.Controls.Add(TableLayoutPanelSubjectButtons, 1, 0);
      TableLayoutPanelSubjects.Dock = DockStyle.Fill;
      TableLayoutPanelSubjects.Location = new Point(570, 3);
      TableLayoutPanelSubjects.Name = "TableLayoutPanelSubjects";
      TableLayoutPanelSubjects.RowCount = 1;
      TableLayoutPanelSubjects.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelSubjects.Size = new Size(561, 588);
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
      DataGridViewSubjects.Size = new Size(392, 582);
      DataGridViewSubjects.TabIndex = 2;
      // 
      // TableLayoutPanelSubjectButtons
      // 
      TableLayoutPanelSubjectButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TableLayoutPanelSubjectButtons.ColumnCount = 1;
      TableLayoutPanelSubjectButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      TableLayoutPanelSubjectButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
      TableLayoutPanelSubjectButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
      TableLayoutPanelSubjectButtons.Controls.Add(ButtonAddSubject, 0, 0);
      TableLayoutPanelSubjectButtons.Controls.Add(ButtonRemoveSubject, 0, 1);
      TableLayoutPanelSubjectButtons.Controls.Add(ButtonSaveSubjects, 0, 2);
      TableLayoutPanelSubjectButtons.Controls.Add(ButtonLoadSubjects, 0, 3);
      TableLayoutPanelSubjectButtons.Location = new Point(401, 3);
      TableLayoutPanelSubjectButtons.Name = "TableLayoutPanelSubjectButtons";
      TableLayoutPanelSubjectButtons.RowCount = 4;
      TableLayoutPanelSubjectButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      TableLayoutPanelSubjectButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      TableLayoutPanelSubjectButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      TableLayoutPanelSubjectButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      TableLayoutPanelSubjectButtons.Size = new Size(157, 221);
      TableLayoutPanelSubjectButtons.TabIndex = 3;
      // 
      // ButtonAddSubject
      // 
      ButtonAddSubject.Dock = DockStyle.Fill;
      ButtonAddSubject.Location = new Point(3, 3);
      ButtonAddSubject.Name = "ButtonAddSubject";
      ButtonAddSubject.Size = new Size(151, 49);
      ButtonAddSubject.TabIndex = 0;
      ButtonAddSubject.Text = "Wahlpflichtfach hinzufügen";
      ButtonAddSubject.UseVisualStyleBackColor = true;
      ButtonAddSubject.Click += ButtonAddSubject_Click;
      // 
      // ButtonRemoveSubject
      // 
      ButtonRemoveSubject.Dock = DockStyle.Fill;
      ButtonRemoveSubject.Location = new Point(3, 58);
      ButtonRemoveSubject.Name = "ButtonRemoveSubject";
      ButtonRemoveSubject.Size = new Size(151, 49);
      ButtonRemoveSubject.TabIndex = 1;
      ButtonRemoveSubject.Text = "Wahlpflichtfach entfernen";
      ButtonRemoveSubject.UseVisualStyleBackColor = true;
      ButtonRemoveSubject.Click += ButtonRemoveSubject_Click;
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
      TableLayoutPanelStudents.Size = new Size(561, 588);
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
      DataGridViewStudents.Size = new Size(392, 582);
      DataGridViewStudents.TabIndex = 2;
      // 
      // TableLayoutPanelStudentButtons
      // 
      TableLayoutPanelStudentButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TableLayoutPanelStudentButtons.ColumnCount = 1;
      TableLayoutPanelStudentButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      TableLayoutPanelStudentButtons.Controls.Add(ButtonAddStudent, 0, 0);
      TableLayoutPanelStudentButtons.Controls.Add(ButtonRemoveStudent, 0, 1);
      TableLayoutPanelStudentButtons.Location = new Point(401, 3);
      TableLayoutPanelStudentButtons.Name = "TableLayoutPanelStudentButtons";
      TableLayoutPanelStudentButtons.RowCount = 2;
      TableLayoutPanelStudentButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelStudentButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelStudentButtons.Size = new Size(157, 125);
      TableLayoutPanelStudentButtons.TabIndex = 3;
      // 
      // ButtonAddStudent
      // 
      ButtonAddStudent.Dock = DockStyle.Fill;
      ButtonAddStudent.Location = new Point(3, 3);
      ButtonAddStudent.Name = "ButtonAddStudent";
      ButtonAddStudent.Size = new Size(151, 56);
      ButtonAddStudent.TabIndex = 0;
      ButtonAddStudent.Text = "Schüler hinzufügen";
      ButtonAddStudent.UseVisualStyleBackColor = true;
      ButtonAddStudent.Click += ButtonAddStudent_Click;
      // 
      // ButtonRemoveStudent
      // 
      ButtonRemoveStudent.Dock = DockStyle.Fill;
      ButtonRemoveStudent.Location = new Point(3, 65);
      ButtonRemoveStudent.Name = "ButtonRemoveStudent";
      ButtonRemoveStudent.Size = new Size(151, 57);
      ButtonRemoveStudent.TabIndex = 1;
      ButtonRemoveStudent.Text = "Schüler entfernen";
      ButtonRemoveStudent.UseVisualStyleBackColor = true;
      ButtonRemoveStudent.Click += ButtonRemoveStudent_Click;
      // 
      // TableLayoutPanelGeneralButtons
      // 
      TableLayoutPanelGeneralButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TableLayoutPanelGeneralButtons.ColumnCount = 1;
      TableLayoutPanelGeneralButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      TableLayoutPanelGeneralButtons.Controls.Add(ButtonCreateTemplate, 0, 0);
      TableLayoutPanelGeneralButtons.Controls.Add(ButtonLoadSelectionResults, 0, 1);
      TableLayoutPanelGeneralButtons.Controls.Add(ButtonCancel, 0, 2);
      TableLayoutPanelGeneralButtons.Location = new Point(1137, 3);
      TableLayoutPanelGeneralButtons.Name = "TableLayoutPanelGeneralButtons";
      TableLayoutPanelGeneralButtons.RowCount = 3;
      TableLayoutPanelGeneralButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
      TableLayoutPanelGeneralButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
      TableLayoutPanelGeneralButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
      TableLayoutPanelGeneralButtons.Size = new Size(120, 227);
      TableLayoutPanelGeneralButtons.TabIndex = 2;
      // 
      // ButtonCreateTemplate
      // 
      ButtonCreateTemplate.Dock = DockStyle.Fill;
      ButtonCreateTemplate.Location = new Point(3, 3);
      ButtonCreateTemplate.Name = "ButtonCreateTemplate";
      ButtonCreateTemplate.Size = new Size(114, 69);
      ButtonCreateTemplate.TabIndex = 0;
      ButtonCreateTemplate.Text = "Vorlage für die Einwahl generieren";
      ButtonCreateTemplate.UseVisualStyleBackColor = true;
      ButtonCreateTemplate.Click += ButtonCreateTemplate_Click;
      // 
      // ButtonLoadSelectionResults
      // 
      ButtonLoadSelectionResults.Dock = DockStyle.Fill;
      ButtonLoadSelectionResults.Location = new Point(3, 78);
      ButtonLoadSelectionResults.Name = "ButtonLoadSelectionResults";
      ButtonLoadSelectionResults.Size = new Size(114, 69);
      ButtonLoadSelectionResults.TabIndex = 1;
      ButtonLoadSelectionResults.Text = "Ergebnisse laden";
      ButtonLoadSelectionResults.UseVisualStyleBackColor = true;
      ButtonLoadSelectionResults.Click += ButtonLoadSelectionResults_Click;
      // 
      // ButtonCancel
      // 
      ButtonCancel.Dock = DockStyle.Fill;
      ButtonCancel.Location = new Point(3, 153);
      ButtonCancel.Name = "ButtonCancel";
      ButtonCancel.Size = new Size(114, 71);
      ButtonCancel.TabIndex = 2;
      ButtonCancel.Text = "Abbrechen";
      ButtonCancel.UseVisualStyleBackColor = true;
      ButtonCancel.Click += ButtonCancel_Click;
      // 
      // ButtonSaveSubjects
      // 
      ButtonSaveSubjects.Dock = DockStyle.Fill;
      ButtonSaveSubjects.Location = new Point(3, 113);
      ButtonSaveSubjects.Name = "ButtonSaveSubjects";
      ButtonSaveSubjects.Size = new Size(151, 49);
      ButtonSaveSubjects.TabIndex = 2;
      ButtonSaveSubjects.Text = "Als JSON speichern";
      ButtonSaveSubjects.UseVisualStyleBackColor = true;
      ButtonSaveSubjects.Click += ButtonSaveSubjects_Click;
      // 
      // ButtonLoadSubjects
      // 
      ButtonLoadSubjects.Dock = DockStyle.Fill;
      ButtonLoadSubjects.Location = new Point(3, 168);
      ButtonLoadSubjects.Name = "ButtonLoadSubjects";
      ButtonLoadSubjects.Size = new Size(151, 50);
      ButtonLoadSubjects.TabIndex = 3;
      ButtonLoadSubjects.Text = "Von JSON laden";
      ButtonLoadSubjects.UseVisualStyleBackColor = true;
      ButtonLoadSubjects.Click += ButtonLoadSubjects_Click;
      // 
      // FormConfigurateTemplate
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1260, 594);
      Controls.Add(TableLayoutPanelMain);
      Name = "FormConfigurateTemplate";
      Text = "Vorbereitung der Fächer und Schüler";
      Load += FormConfigurateSubjects_Load;
      TableLayoutPanelMain.ResumeLayout(false);
      TableLayoutPanelSubjects.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)DataGridViewSubjects).EndInit();
      TableLayoutPanelSubjectButtons.ResumeLayout(false);
      TableLayoutPanelStudents.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)DataGridViewStudents).EndInit();
      TableLayoutPanelStudentButtons.ResumeLayout(false);
      TableLayoutPanelGeneralButtons.ResumeLayout(false);
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
    private TableLayoutPanel TableLayoutPanelGeneralButtons;
    private Button ButtonCreateTemplate;
    private Button ButtonLoadSelectionResults;
    private Button ButtonCancel;
    private Button ButtonSaveSubjects;
    private Button ButtonLoadSubjects;
  }
}