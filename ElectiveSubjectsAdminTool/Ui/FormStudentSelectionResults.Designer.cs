namespace ElectiveSubjectsAdminTool.Ui
{
  partial class FormStudentSelectionResults
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
      DataGridViewSelections = new DataGridView();
      TableLayoutPanelButtons = new TableLayoutPanel();
      ButtonAlgorithm = new Button();
      ButtonExport = new Button();
      ButtonEdit = new Button();
      ButtonClose = new Button();
      TableLayoutPanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)DataGridViewSelections).BeginInit();
      TableLayoutPanelButtons.SuspendLayout();
      SuspendLayout();
      // 
      // TableLayoutPanelMain
      // 
      TableLayoutPanelMain.ColumnCount = 2;
      TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.625F));
      TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.375F));
      TableLayoutPanelMain.Controls.Add(DataGridViewSelections, 0, 0);
      TableLayoutPanelMain.Controls.Add(TableLayoutPanelButtons, 1, 0);
      TableLayoutPanelMain.Dock = DockStyle.Fill;
      TableLayoutPanelMain.Location = new Point(0, 0);
      TableLayoutPanelMain.Name = "TableLayoutPanelMain";
      TableLayoutPanelMain.RowCount = 1;
      TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TableLayoutPanelMain.Size = new Size(800, 450);
      TableLayoutPanelMain.TabIndex = 0;
      // 
      // DataGridViewSelections
      // 
      DataGridViewSelections.AllowUserToAddRows = false;
      DataGridViewSelections.AllowUserToDeleteRows = false;
      DataGridViewSelections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      DataGridViewSelections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      DataGridViewSelections.Dock = DockStyle.Fill;
      DataGridViewSelections.Location = new Point(3, 3);
      DataGridViewSelections.MultiSelect = false;
      DataGridViewSelections.Name = "DataGridViewSelections";
      DataGridViewSelections.ReadOnly = true;
      DataGridViewSelections.RowHeadersVisible = false;
      DataGridViewSelections.RowHeadersWidth = 51;
      DataGridViewSelections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      DataGridViewSelections.Size = new Size(663, 444);
      DataGridViewSelections.TabIndex = 3;
      DataGridViewSelections.SelectionChanged += DataGridViewSelections_SelectionChanged;
      // 
      // TableLayoutPanelButtons
      // 
      TableLayoutPanelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TableLayoutPanelButtons.ColumnCount = 1;
      TableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      TableLayoutPanelButtons.Controls.Add(ButtonAlgorithm, 0, 0);
      TableLayoutPanelButtons.Controls.Add(ButtonExport, 0, 1);
      TableLayoutPanelButtons.Controls.Add(ButtonEdit, 0, 2);
      TableLayoutPanelButtons.Controls.Add(ButtonClose, 0, 3);
      TableLayoutPanelButtons.Location = new Point(672, 3);
      TableLayoutPanelButtons.Name = "TableLayoutPanelButtons";
      TableLayoutPanelButtons.RowCount = 4;
      TableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      TableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      TableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      TableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      TableLayoutPanelButtons.Size = new Size(125, 226);
      TableLayoutPanelButtons.TabIndex = 4;
      // 
      // ButtonAlgorithm
      // 
      ButtonAlgorithm.Dock = DockStyle.Fill;
      ButtonAlgorithm.Location = new Point(3, 3);
      ButtonAlgorithm.Name = "ButtonAlgorithm";
      ButtonAlgorithm.Size = new Size(119, 50);
      ButtonAlgorithm.TabIndex = 0;
      ButtonAlgorithm.Text = "Neusortieren";
      ButtonAlgorithm.UseVisualStyleBackColor = true;
      ButtonAlgorithm.Click += ButtonAlgorithm_Click;
      // 
      // ButtonExport
      // 
      ButtonExport.Dock = DockStyle.Fill;
      ButtonExport.Location = new Point(3, 59);
      ButtonExport.Name = "ButtonExport";
      ButtonExport.Size = new Size(119, 50);
      ButtonExport.TabIndex = 1;
      ButtonExport.Text = "Als CSV exportieren";
      ButtonExport.UseVisualStyleBackColor = true;
      ButtonExport.Click += ButtonExport_Click;
      // 
      // ButtonEdit
      // 
      ButtonEdit.Dock = DockStyle.Fill;
      ButtonEdit.Location = new Point(3, 115);
      ButtonEdit.Name = "ButtonEdit";
      ButtonEdit.Size = new Size(119, 50);
      ButtonEdit.TabIndex = 2;
      ButtonEdit.Text = "Eintrag bearbeiten";
      ButtonEdit.UseVisualStyleBackColor = true;
      ButtonEdit.Click += ButtonEdit_Click;
      // 
      // ButtonClose
      // 
      ButtonClose.Dock = DockStyle.Fill;
      ButtonClose.Location = new Point(3, 171);
      ButtonClose.Name = "ButtonClose";
      ButtonClose.Size = new Size(119, 52);
      ButtonClose.TabIndex = 3;
      ButtonClose.Text = "Beenden";
      ButtonClose.UseVisualStyleBackColor = true;
      ButtonClose.Click += ButtonClose_Click;
      // 
      // FormStudentSelectionResults
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(TableLayoutPanelMain);
      Name = "FormStudentSelectionResults";
      Text = "Ergebnisse der Schülerwahlen";
      Load += FormStudentSelectionResults_Load;
      TableLayoutPanelMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)DataGridViewSelections).EndInit();
      TableLayoutPanelButtons.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel TableLayoutPanelMain;
    private DataGridView DataGridViewSelections;
    private TableLayoutPanel TableLayoutPanelButtons;
    private Button ButtonAlgorithm;
    private Button ButtonExport;
    private Button ButtonEdit;
    private Button ButtonClose;
  }
}