namespace ElectiveSubjectsAdminTool
{
  partial class FormConfigurateStudent
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
      LabelId = new Label();
      LabelFirstName = new Label();
      LabelLastName = new Label();
      TextBoxId = new TextBox();
      TextBoxFirstName = new TextBox();
      TextBoxLastName = new TextBox();
      ButtonAccept = new Button();
      ButtonCancel = new Button();
      SuspendLayout();
      // 
      // LabelId
      // 
      LabelId.AutoSize = true;
      LabelId.Location = new Point(68, 9);
      LabelId.Name = "LabelId";
      LabelId.Size = new Size(24, 20);
      LabelId.TabIndex = 0;
      LabelId.Text = "ID";
      // 
      // LabelFirstName
      // 
      LabelFirstName.AutoSize = true;
      LabelFirstName.Location = new Point(24, 43);
      LabelFirstName.Name = "LabelFirstName";
      LabelFirstName.Size = new Size(68, 20);
      LabelFirstName.TabIndex = 1;
      LabelFirstName.Text = "Vorname";
      // 
      // LabelLastName
      // 
      LabelLastName.AutoSize = true;
      LabelLastName.Location = new Point(12, 79);
      LabelLastName.Name = "LabelLastName";
      LabelLastName.Size = new Size(80, 20);
      LabelLastName.TabIndex = 2;
      LabelLastName.Text = "Nachname";
      // 
      // TextBoxId
      // 
      TextBoxId.Location = new Point(117, 6);
      TextBoxId.Name = "TextBoxId";
      TextBoxId.Size = new Size(182, 27);
      TextBoxId.TabIndex = 3;
      // 
      // TextBoxFirstName
      // 
      TextBoxFirstName.Location = new Point(117, 40);
      TextBoxFirstName.Name = "TextBoxFirstName";
      TextBoxFirstName.Size = new Size(182, 27);
      TextBoxFirstName.TabIndex = 4;
      // 
      // TextBoxLastName
      // 
      TextBoxLastName.Location = new Point(117, 76);
      TextBoxLastName.Name = "TextBoxLastName";
      TextBoxLastName.Size = new Size(182, 27);
      TextBoxLastName.TabIndex = 5;
      // 
      // ButtonAccept
      // 
      ButtonAccept.Location = new Point(12, 125);
      ButtonAccept.Name = "ButtonAccept";
      ButtonAccept.Size = new Size(94, 29);
      ButtonAccept.TabIndex = 6;
      ButtonAccept.Text = "Ok";
      ButtonAccept.UseVisualStyleBackColor = true;
      ButtonAccept.Click += ButtonAccept_Click;
      // 
      // ButtonCancel
      // 
      ButtonCancel.Location = new Point(205, 125);
      ButtonCancel.Name = "ButtonCancel";
      ButtonCancel.Size = new Size(94, 29);
      ButtonCancel.TabIndex = 7;
      ButtonCancel.Text = "Abbrechen";
      ButtonCancel.UseVisualStyleBackColor = true;
      ButtonCancel.Click += ButtonCancel_Click;
      // 
      // FormConfigurateStudent
      // 
      AcceptButton = ButtonAccept;
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = ButtonCancel;
      ClientSize = new Size(311, 166);
      Controls.Add(ButtonCancel);
      Controls.Add(ButtonAccept);
      Controls.Add(TextBoxLastName);
      Controls.Add(TextBoxFirstName);
      Controls.Add(TextBoxId);
      Controls.Add(LabelLastName);
      Controls.Add(LabelFirstName);
      Controls.Add(LabelId);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormConfigurateStudent";
      Text = "Schüler anlegen";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LabelId;
    private Label LabelFirstName;
    private Label LabelLastName;
    private TextBox TextBoxId;
    private TextBox TextBoxFirstName;
    private TextBox TextBoxLastName;
    private Button ButtonAccept;
    private Button ButtonCancel;
  }
}