namespace ElectiveSubjectsAdminTool.Ui
{
  public partial class FormConfigurateSubject : Form
  {
    private Subject? _createdSubject;

    public FormConfigurateSubject() {
      InitializeComponent();
    }

    private void ButtonAccept_Click(object sender, EventArgs e) {
      if (ValidateInputs(out var errors)) {
        _createdSubject = new Subject(TextBoxName.Text, TextBoxDescription.Text);
        DialogResult = DialogResult.OK;
        Close();
      } else {
        MessageBox.Show(string.Join(Environment.NewLine, errors),
          "Achtung!",
          MessageBoxButtons.OK,
          MessageBoxIcon.Warning);
      }
    }

    private bool ValidateInputs(out string[] errors) {
      var result = new List<string>();

      if (string.IsNullOrEmpty(TextBoxName.Text)) {
        result.Add("Der Name darf nicht leer sein.");
      }

      if (string.IsNullOrEmpty(TextBoxDescription.Text)) {
        result.Add("Die Beschreibung darf nicht leer sein.");
      }

      errors = result.ToArray();
      return result.Count > 0;
    }

    private void ButtonCancel_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    public Subject GetSubject() {
      ArgumentNullException.ThrowIfNull(_createdSubject);
      return _createdSubject;
    }
  }
}
