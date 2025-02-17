namespace ElectiveSubjectsAdminTool.Ui
{
  partial class FormEditStudentSelection
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
      GroupBoxStudentInfo = new GroupBox();
      LabelStudenJobType = new Label();
      LabelStudentLastName = new Label();
      LabelStudentFirstName = new Label();
      LabelStudentId = new Label();
      LabelFirstChoice = new Label();
      LabelSecondChoice = new Label();
      LabelThirdChoice = new Label();
      ComboBoxFirstChoice = new ComboBox();
      ComboBoxSecondChoice = new ComboBox();
      ComboBoxThirdChoice = new ComboBox();
      ButtonDone = new Button();
      ButtonCancel = new Button();
      GroupBoxStudentInfo.SuspendLayout();
      SuspendLayout();
      // 
      // GroupBoxStudentInfo
      // 
      GroupBoxStudentInfo.Controls.Add(LabelStudenJobType);
      GroupBoxStudentInfo.Controls.Add(LabelStudentLastName);
      GroupBoxStudentInfo.Controls.Add(LabelStudentFirstName);
      GroupBoxStudentInfo.Controls.Add(LabelStudentId);
      GroupBoxStudentInfo.Location = new Point(12, 12);
      GroupBoxStudentInfo.Name = "GroupBoxStudentInfo";
      GroupBoxStudentInfo.Size = new Size(340, 147);
      GroupBoxStudentInfo.TabIndex = 0;
      GroupBoxStudentInfo.TabStop = false;
      GroupBoxStudentInfo.Text = "Schülerinformationen";
      // 
      // LabelStudenJobType
      // 
      LabelStudenJobType.AutoSize = true;
      LabelStudenJobType.Location = new Point(6, 114);
      LabelStudenJobType.Name = "LabelStudenJobType";
      LabelStudenJobType.Size = new Size(50, 20);
      LabelStudenJobType.TabIndex = 4;
      LabelStudenJobType.Text = "label4";
      // 
      // LabelStudentLastName
      // 
      LabelStudentLastName.AutoSize = true;
      LabelStudentLastName.Location = new Point(6, 83);
      LabelStudentLastName.Name = "LabelStudentLastName";
      LabelStudentLastName.Size = new Size(50, 20);
      LabelStudentLastName.TabIndex = 3;
      LabelStudentLastName.Text = "label3";
      // 
      // LabelStudentFirstName
      // 
      LabelStudentFirstName.AutoSize = true;
      LabelStudentFirstName.Location = new Point(6, 53);
      LabelStudentFirstName.Name = "LabelStudentFirstName";
      LabelStudentFirstName.Size = new Size(50, 20);
      LabelStudentFirstName.TabIndex = 2;
      LabelStudentFirstName.Text = "label2";
      // 
      // LabelStudentId
      // 
      LabelStudentId.AutoSize = true;
      LabelStudentId.Location = new Point(6, 23);
      LabelStudentId.Name = "LabelStudentId";
      LabelStudentId.Size = new Size(50, 20);
      LabelStudentId.TabIndex = 1;
      LabelStudentId.Text = "label1";
      // 
      // LabelFirstChoice
      // 
      LabelFirstChoice.AutoSize = true;
      LabelFirstChoice.Location = new Point(396, 17);
      LabelFirstChoice.Name = "LabelFirstChoice";
      LabelFirstChoice.Size = new Size(78, 20);
      LabelFirstChoice.TabIndex = 1;
      LabelFirstChoice.Text = "Erste Wahl";
      // 
      // LabelSecondChoice
      // 
      LabelSecondChoice.AutoSize = true;
      LabelSecondChoice.Location = new Point(396, 65);
      LabelSecondChoice.Name = "LabelSecondChoice";
      LabelSecondChoice.Size = new Size(91, 20);
      LabelSecondChoice.TabIndex = 2;
      LabelSecondChoice.Text = "Zweite Wahl";
      // 
      // LabelThirdChoice
      // 
      LabelThirdChoice.AutoSize = true;
      LabelThirdChoice.Location = new Point(396, 114);
      LabelThirdChoice.Name = "LabelThirdChoice";
      LabelThirdChoice.Size = new Size(84, 20);
      LabelThirdChoice.TabIndex = 3;
      LabelThirdChoice.Text = "Dritte Wahl";
      // 
      // ComboBoxFirstChoice
      // 
      ComboBoxFirstChoice.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBoxFirstChoice.FormattingEnabled = true;
      ComboBoxFirstChoice.Location = new Point(493, 14);
      ComboBoxFirstChoice.Name = "ComboBoxFirstChoice";
      ComboBoxFirstChoice.Size = new Size(295, 28);
      ComboBoxFirstChoice.TabIndex = 4;
      ComboBoxFirstChoice.SelectedIndexChanged += ComboBoxFirstChoice_SelectedIndexChanged;
      // 
      // ComboBoxSecondChoice
      // 
      ComboBoxSecondChoice.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBoxSecondChoice.FormattingEnabled = true;
      ComboBoxSecondChoice.Location = new Point(493, 62);
      ComboBoxSecondChoice.Name = "ComboBoxSecondChoice";
      ComboBoxSecondChoice.Size = new Size(295, 28);
      ComboBoxSecondChoice.TabIndex = 5;
      ComboBoxSecondChoice.SelectedIndexChanged += ComboBoxSecondChoice_SelectedIndexChanged;
      // 
      // ComboBoxThirdChoice
      // 
      ComboBoxThirdChoice.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBoxThirdChoice.FormattingEnabled = true;
      ComboBoxThirdChoice.Location = new Point(493, 111);
      ComboBoxThirdChoice.Name = "ComboBoxThirdChoice";
      ComboBoxThirdChoice.Size = new Size(295, 28);
      ComboBoxThirdChoice.TabIndex = 6;
      ComboBoxThirdChoice.SelectedIndexChanged += ComboBoxThirdChoice_SelectedIndexChanged;
      // 
      // ButtonDone
      // 
      ButtonDone.Location = new Point(12, 170);
      ButtonDone.Name = "ButtonDone";
      ButtonDone.Size = new Size(94, 29);
      ButtonDone.TabIndex = 7;
      ButtonDone.Text = "Fertig";
      ButtonDone.UseVisualStyleBackColor = true;
      ButtonDone.Click += ButtonDone_Click;
      // 
      // ButtonCancel
      // 
      ButtonCancel.Location = new Point(694, 170);
      ButtonCancel.Name = "ButtonCancel";
      ButtonCancel.Size = new Size(94, 29);
      ButtonCancel.TabIndex = 8;
      ButtonCancel.Text = "Abbrechen";
      ButtonCancel.UseVisualStyleBackColor = true;
      ButtonCancel.Click += ButtonCancel_Click;
      // 
      // FormEditStudentSelection
      // 
      AcceptButton = ButtonDone;
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = ButtonCancel;
      ClientSize = new Size(800, 211);
      Controls.Add(ButtonCancel);
      Controls.Add(ButtonDone);
      Controls.Add(ComboBoxThirdChoice);
      Controls.Add(ComboBoxSecondChoice);
      Controls.Add(ComboBoxFirstChoice);
      Controls.Add(LabelThirdChoice);
      Controls.Add(LabelSecondChoice);
      Controls.Add(LabelFirstChoice);
      Controls.Add(GroupBoxStudentInfo);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormEditStudentSelection";
      Text = "Wahlpflichtfächer des Schülers bearbeiten";
      Load += FormEditStudentSelection_Load;
      GroupBoxStudentInfo.ResumeLayout(false);
      GroupBoxStudentInfo.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private GroupBox GroupBoxStudentInfo;
    private Label LabelStudentId;
    private Label LabelStudenJobType;
    private Label LabelStudentLastName;
    private Label LabelStudentFirstName;
    private Label LabelFirstChoice;
    private Label LabelSecondChoice;
    private Label LabelThirdChoice;
    private ComboBox ComboBoxFirstChoice;
    private ComboBox ComboBoxSecondChoice;
    private ComboBox ComboBoxThirdChoice;
    private Button ButtonDone;
    private Button ButtonCancel;
  }
}