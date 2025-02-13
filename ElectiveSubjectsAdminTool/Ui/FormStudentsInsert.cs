namespace ElectiveSubjectsAdminTool
{
  public partial class FormStudentsInsert : Form
  {
    private StudentCollection? _students;

    public FormStudentsInsert() {
      InitializeComponent();
    }

    private void ButtonClose_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    private void ButtonChooseFile_Click(object sender, EventArgs e) {
      DialogResult? dialogueResult = null;
      var path = string.Empty;

      using (var fileDialogue = new OpenFileDialog()) {
        fileDialogue.RestoreDirectory = true;
        fileDialogue.Filter = "CSV-Dateien (*.csv)|*.csv|Alle Dateien (*.*)|*.*";
        fileDialogue.Multiselect = false;
        dialogueResult = fileDialogue.ShowDialog();
        path = fileDialogue.FileName;
      }

      if (dialogueResult == DialogResult.OK) {
        if (StudentCollection.TryCreateFromCsv(path, out var error, out var students)) {
          _students = students;
          SetLabelTexts(path);
        } else {
          MessageBox.Show(error, "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      } else {
        MessageBox.Show("Die Auswahl der Datei wurde abgebrochen.",
          "Vorgang abgebrochen",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);

        SetLabelTexts(null);
      }

      EnableButtons();
    }

    private void FormStudentsInsert_Load(object sender, EventArgs e) {
      SetLabelTexts(null);
      EnableButtons();
    }

    private void SetLabelTexts(string? path) {
      if (string.IsNullOrEmpty(path)) {
        LabelFileName.Text = "Keine Datei ausgewählt.";
      } else {
        LabelFileName.Text = "Dateipfad: " + path;
      }

      LabelStudentCount.Text = "Anzahl erkannter Schüler: " +
        (_students is null ? 0 : _students.Count).ToString();
    }

    private void EnableButtons() {
      ButtonContinue.Enabled = _students is not null;
    }

    public StudentCollection GetStudents() {
      ArgumentNullException.ThrowIfNull(_students);
      return _students;
    }

    private void ButtonContinue_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}
