namespace ElectiveSubjectsAdminTool.Ui
{
  partial class FormConfigurateSubject
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
      LabelName = new Label();
      LabelDescription = new Label();
      TextBoxName = new TextBox();
      TextBoxDescription = new TextBox();
      ButtonAccept = new Button();
      ButtonCancel = new Button();
      SuspendLayout();
      // 
      // LabelName
      // 
      LabelName.AutoSize = true;
      LabelName.Location = new Point(61, 13);
      LabelName.Name = "LabelName";
      LabelName.Size = new Size(49, 20);
      LabelName.TabIndex = 0;
      LabelName.Text = "Name";
      // 
      // LabelDescription
      // 
      LabelDescription.AutoSize = true;
      LabelDescription.Location = new Point(12, 53);
      LabelDescription.Name = "LabelDescription";
      LabelDescription.Size = new Size(98, 20);
      LabelDescription.TabIndex = 1;
      LabelDescription.Text = "Beschreibung";
      // 
      // TextBoxName
      // 
      TextBoxName.Location = new Point(116, 10);
      TextBoxName.Name = "TextBoxName";
      TextBoxName.Size = new Size(263, 27);
      TextBoxName.TabIndex = 2;
      // 
      // TextBoxDescription
      // 
      TextBoxDescription.Location = new Point(116, 50);
      TextBoxDescription.MaxLength = 1000;
      TextBoxDescription.Multiline = true;
      TextBoxDescription.Name = "TextBoxDescription";
      TextBoxDescription.Size = new Size(263, 324);
      TextBoxDescription.TabIndex = 3;
      // 
      // ButtonAccept
      // 
      ButtonAccept.Location = new Point(12, 409);
      ButtonAccept.Name = "ButtonAccept";
      ButtonAccept.Size = new Size(94, 29);
      ButtonAccept.TabIndex = 4;
      ButtonAccept.Text = "Ok";
      ButtonAccept.UseVisualStyleBackColor = true;
      ButtonAccept.Click += ButtonAccept_Click;
      // 
      // ButtonCancel
      // 
      ButtonCancel.Location = new Point(285, 409);
      ButtonCancel.Name = "ButtonCancel";
      ButtonCancel.Size = new Size(94, 29);
      ButtonCancel.TabIndex = 5;
      ButtonCancel.Text = "Abbrechen";
      ButtonCancel.UseVisualStyleBackColor = true;
      ButtonCancel.Click += ButtonCancel_Click;
      // 
      // FormConfigurateSubject
      // 
      AcceptButton = ButtonAccept;
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = ButtonCancel;
      ClientSize = new Size(391, 450);
      Controls.Add(ButtonCancel);
      Controls.Add(ButtonAccept);
      Controls.Add(TextBoxDescription);
      Controls.Add(TextBoxName);
      Controls.Add(LabelDescription);
      Controls.Add(LabelName);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormConfigurateSubject";
      Text = "Wahlpflichtfach erstellen";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LabelName;
    private Label LabelDescription;
    private TextBox TextBoxName;
    private TextBox TextBoxDescription;
    private Button ButtonAccept;
    private Button ButtonCancel;
  }
}