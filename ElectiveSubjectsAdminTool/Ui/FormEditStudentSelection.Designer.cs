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
      LabelFirstChoice = new Label();
      LabelSecondChoice = new Label();
      LabelThirdChoice = new Label();
      ComboBoxFirstChoice = new ComboBox();
      ComboBoxSecondChoice = new ComboBox();
      ComboBoxThirdChoice = new ComboBox();
      ButtonDone = new Button();
      ButtonCancel = new Button();
      LabelId = new Label();
      SuspendLayout();
      // 
      // LabelFirstChoice
      // 
      LabelFirstChoice.AutoSize = true;
      LabelFirstChoice.Location = new Point(12, 45);
      LabelFirstChoice.Name = "LabelFirstChoice";
      LabelFirstChoice.Size = new Size(78, 20);
      LabelFirstChoice.TabIndex = 1;
      LabelFirstChoice.Text = "Erste Wahl";
      // 
      // LabelSecondChoice
      // 
      LabelSecondChoice.AutoSize = true;
      LabelSecondChoice.Location = new Point(12, 78);
      LabelSecondChoice.Name = "LabelSecondChoice";
      LabelSecondChoice.Size = new Size(91, 20);
      LabelSecondChoice.TabIndex = 2;
      LabelSecondChoice.Text = "Zweite Wahl";
      // 
      // LabelThirdChoice
      // 
      LabelThirdChoice.AutoSize = true;
      LabelThirdChoice.Location = new Point(12, 115);
      LabelThirdChoice.Name = "LabelThirdChoice";
      LabelThirdChoice.Size = new Size(84, 20);
      LabelThirdChoice.TabIndex = 3;
      LabelThirdChoice.Text = "Dritte Wahl";
      // 
      // ComboBoxFirstChoice
      // 
      ComboBoxFirstChoice.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBoxFirstChoice.FormattingEnabled = true;
      ComboBoxFirstChoice.Location = new Point(109, 42);
      ComboBoxFirstChoice.Name = "ComboBoxFirstChoice";
      ComboBoxFirstChoice.Size = new Size(295, 28);
      ComboBoxFirstChoice.TabIndex = 4;
      ComboBoxFirstChoice.SelectedIndexChanged += ComboBoxFirstChoice_SelectedIndexChanged;
      // 
      // ComboBoxSecondChoice
      // 
      ComboBoxSecondChoice.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBoxSecondChoice.FormattingEnabled = true;
      ComboBoxSecondChoice.Location = new Point(109, 75);
      ComboBoxSecondChoice.Name = "ComboBoxSecondChoice";
      ComboBoxSecondChoice.Size = new Size(295, 28);
      ComboBoxSecondChoice.TabIndex = 5;
      ComboBoxSecondChoice.SelectedIndexChanged += ComboBoxSecondChoice_SelectedIndexChanged;
      // 
      // ComboBoxThirdChoice
      // 
      ComboBoxThirdChoice.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBoxThirdChoice.FormattingEnabled = true;
      ComboBoxThirdChoice.Location = new Point(109, 112);
      ComboBoxThirdChoice.Name = "ComboBoxThirdChoice";
      ComboBoxThirdChoice.Size = new Size(295, 28);
      ComboBoxThirdChoice.TabIndex = 6;
      ComboBoxThirdChoice.SelectedIndexChanged += ComboBoxThirdChoice_SelectedIndexChanged;
      // 
      // ButtonDone
      // 
      ButtonDone.Location = new Point(12, 169);
      ButtonDone.Name = "ButtonDone";
      ButtonDone.Size = new Size(94, 29);
      ButtonDone.TabIndex = 7;
      ButtonDone.Text = "Fertig";
      ButtonDone.UseVisualStyleBackColor = true;
      ButtonDone.Click += ButtonDone_Click;
      // 
      // ButtonCancel
      // 
      ButtonCancel.Location = new Point(318, 169);
      ButtonCancel.Name = "ButtonCancel";
      ButtonCancel.Size = new Size(94, 29);
      ButtonCancel.TabIndex = 8;
      ButtonCancel.Text = "Abbrechen";
      ButtonCancel.UseVisualStyleBackColor = true;
      ButtonCancel.Click += ButtonCancel_Click;
      // 
      // LabelId
      // 
      LabelId.AutoSize = true;
      LabelId.Location = new Point(12, 9);
      LabelId.Name = "LabelId";
      LabelId.Size = new Size(50, 20);
      LabelId.TabIndex = 9;
      LabelId.Text = "label1";
      // 
      // FormEditStudentSelection
      // 
      AcceptButton = ButtonDone;
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = ButtonCancel;
      ClientSize = new Size(424, 210);
      Controls.Add(LabelId);
      Controls.Add(ButtonCancel);
      Controls.Add(ButtonDone);
      Controls.Add(ComboBoxThirdChoice);
      Controls.Add(ComboBoxSecondChoice);
      Controls.Add(ComboBoxFirstChoice);
      Controls.Add(LabelThirdChoice);
      Controls.Add(LabelSecondChoice);
      Controls.Add(LabelFirstChoice);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormEditStudentSelection";
      Text = "Wahlpflichtfächer des Schülers bearbeiten";
      Load += FormEditStudentSelection_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Label LabelFirstChoice;
    private Label LabelSecondChoice;
    private Label LabelThirdChoice;
    private ComboBox ComboBoxFirstChoice;
    private ComboBox ComboBoxSecondChoice;
    private ComboBox ComboBoxThirdChoice;
    private Button ButtonDone;
    private Button ButtonCancel;
    private Label LabelId;
  }
}