namespace ElectiveSubjectsAdminTool.Ui
{
  partial class FormStart
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
      LabelMain = new Label();
      ButtonTemplate = new Button();
      ButtonSelectionResults = new Button();
      ButtonCancel = new Button();
      SuspendLayout();
      // 
      // LabelMain
      // 
      LabelMain.AutoSize = true;
      LabelMain.Location = new Point(86, 9);
      LabelMain.Name = "LabelMain";
      LabelMain.Size = new Size(154, 20);
      LabelMain.TabIndex = 0;
      LabelMain.Text = "Was möchten Sie tun?";
      // 
      // ButtonTemplate
      // 
      ButtonTemplate.Location = new Point(12, 72);
      ButtonTemplate.Name = "ButtonTemplate";
      ButtonTemplate.Size = new Size(141, 74);
      ButtonTemplate.TabIndex = 1;
      ButtonTemplate.Text = "Eine Webvorlage erstellen";
      ButtonTemplate.UseVisualStyleBackColor = true;
      ButtonTemplate.Click += ButtonTemplate_Click;
      // 
      // ButtonSelectionResults
      // 
      ButtonSelectionResults.Location = new Point(178, 72);
      ButtonSelectionResults.Name = "ButtonSelectionResults";
      ButtonSelectionResults.Size = new Size(141, 74);
      ButtonSelectionResults.TabIndex = 2;
      ButtonSelectionResults.Text = "Einwahlergebnisse laden";
      ButtonSelectionResults.UseVisualStyleBackColor = true;
      ButtonSelectionResults.Click += ButtonSelectionResults_Click;
      // 
      // ButtonCancel
      // 
      ButtonCancel.Location = new Point(225, 177);
      ButtonCancel.Name = "ButtonCancel";
      ButtonCancel.Size = new Size(94, 29);
      ButtonCancel.TabIndex = 3;
      ButtonCancel.Text = "Beenden";
      ButtonCancel.UseVisualStyleBackColor = true;
      ButtonCancel.Click += ButtonCancel_Click;
      // 
      // FormStart
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = ButtonCancel;
      ClientSize = new Size(331, 218);
      Controls.Add(ButtonCancel);
      Controls.Add(ButtonSelectionResults);
      Controls.Add(ButtonTemplate);
      Controls.Add(LabelMain);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormStart";
      Text = "Willkommen";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LabelMain;
    private Button ButtonTemplate;
    private Button ButtonSelectionResults;
    private Button ButtonCancel;
  }
}