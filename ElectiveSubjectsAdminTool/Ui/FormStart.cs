namespace ElectiveSubjectsAdminTool.Ui
{
  public partial class FormStart : Form
  {
    private DialogueContinueType _continueType;

    public FormStart() {
      InitializeComponent();
      _continueType = DialogueContinueType.None;
    }

    public DialogueContinueType GetDialogueContinueType() {
      return _continueType;
    }

    private void ButtonCancel_Click(object sender, EventArgs e) {
      Close();
    }

    private void ButtonTemplate_Click(object sender, EventArgs e) {
      _continueType = DialogueContinueType.GenerateTemplate;
      Close();
    }

    private void ButtonSelectionResults_Click(object sender, EventArgs e) {
      _continueType = DialogueContinueType.SelectionResults;
      Close();
    }
  }
}
