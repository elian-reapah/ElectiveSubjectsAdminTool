namespace ElectiveSubjectsAdminTool
{
  partial class FormStudentsInsert
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
      ButtonContinue = new Button();
      ButtonClose = new Button();
      ButtonChooseFile = new Button();
      GroupBoxFileInfo = new GroupBox();
      LabelStudentCount = new Label();
      LabelFileName = new Label();
      GroupBoxFileInfo.SuspendLayout();
      SuspendLayout();
      // 
      // ButtonContinue
      // 
      ButtonContinue.Location = new Point(348, 89);
      ButtonContinue.Name = "ButtonContinue";
      ButtonContinue.Size = new Size(94, 29);
      ButtonContinue.TabIndex = 0;
      ButtonContinue.Text = "Weiter";
      ButtonContinue.UseVisualStyleBackColor = true;
      ButtonContinue.Click += ButtonContinue_Click;
      // 
      // ButtonClose
      // 
      ButtonClose.Location = new Point(348, 119);
      ButtonClose.Name = "ButtonClose";
      ButtonClose.Size = new Size(94, 29);
      ButtonClose.TabIndex = 1;
      ButtonClose.Text = "Abbrechen";
      ButtonClose.UseVisualStyleBackColor = true;
      ButtonClose.Click += ButtonClose_Click;
      // 
      // ButtonChooseFile
      // 
      ButtonChooseFile.Location = new Point(348, 21);
      ButtonChooseFile.Name = "ButtonChooseFile";
      ButtonChooseFile.Size = new Size(94, 51);
      ButtonChooseFile.TabIndex = 2;
      ButtonChooseFile.Text = "Datei auswählen";
      ButtonChooseFile.UseVisualStyleBackColor = true;
      ButtonChooseFile.Click += ButtonChooseFile_Click;
      // 
      // GroupBoxFileInfo
      // 
      GroupBoxFileInfo.Controls.Add(LabelStudentCount);
      GroupBoxFileInfo.Controls.Add(LabelFileName);
      GroupBoxFileInfo.Location = new Point(12, 12);
      GroupBoxFileInfo.Name = "GroupBoxFileInfo";
      GroupBoxFileInfo.Size = new Size(330, 136);
      GroupBoxFileInfo.TabIndex = 3;
      GroupBoxFileInfo.TabStop = false;
      GroupBoxFileInfo.Text = "Datei-Informationen";
      // 
      // LabelStudentCount
      // 
      LabelStudentCount.AutoSize = true;
      LabelStudentCount.Location = new Point(6, 86);
      LabelStudentCount.Name = "LabelStudentCount";
      LabelStudentCount.Size = new Size(50, 20);
      LabelStudentCount.TabIndex = 4;
      LabelStudentCount.Text = "label1";
      // 
      // LabelFileName
      // 
      LabelFileName.AutoSize = true;
      LabelFileName.Location = new Point(6, 24);
      LabelFileName.Name = "LabelFileName";
      LabelFileName.Size = new Size(50, 20);
      LabelFileName.TabIndex = 0;
      LabelFileName.Text = "label1";
      // 
      // FormStudentsInsert
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = ButtonClose;
      ClientSize = new Size(454, 160);
      Controls.Add(GroupBoxFileInfo);
      Controls.Add(ButtonChooseFile);
      Controls.Add(ButtonClose);
      Controls.Add(ButtonContinue);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormStudentsInsert";
      Text = "Schülerdaten einfügen";
      Load += FormStudentsInsert_Load;
      GroupBoxFileInfo.ResumeLayout(false);
      GroupBoxFileInfo.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private Button ButtonContinue;
    private Button ButtonClose;
    private Button ButtonChooseFile;
    private GroupBox GroupBoxFileInfo;
    private Label LabelStudentCount;
    private Label LabelFileName;
  }
}