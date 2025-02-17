namespace ElectiveSubjectsAdminTool.Ui
{
  public partial class FormStudentSelectionResults : Form
  {
    private readonly StudentSelectionCollection _selections;
    private readonly SubjectCollection _subjects;

    public FormStudentSelectionResults(StudentSelectionCollection selections, SubjectCollection subjects) {
      InitializeComponent();
      _selections = selections;
      _subjects = subjects;
    }

    private void ButtonAlgorithm_Click(object sender, EventArgs e) {
      // Hier würden die Einwahlen mithilfe des Algorithmus neusortiert werden
    }

    private void ButtonExport_Click(object sender, EventArgs e) {
      var now = DateTime.Now;
      string? folderPath = null;

      using (var dialogue = new FolderBrowserDialog()) {
        dialogue.Multiselect = false;

        if (dialogue.ShowDialog() == DialogResult.OK) {
          folderPath = dialogue.SelectedPath;
        }
      }

      if (folderPath is not null) {
        var file = "einwahl_ergebnisse_" + now.ToString("dd_MM_yyyy") + ".json";
        var path = Path.Combine(folderPath, file);

        if (FileHelp.TryCreateFile(path, _selections.GetAsCsvLines(), out var error)) {
          MessageBox.Show("Die Datei: " + file + " wurde erfolgreich gespeichert unter: " + path,
          "Erfolgreich gespeichert",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        } else {
          MessageBox.Show(error,
          "Speichern fehlgeschlagen",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        }
      }
    }

    private void EnableButtons() {
      ButtonEdit.Enabled = DataGridViewSelections.SelectedRows.Count == 1;
    }

    private void ButtonEdit_Click(object sender, EventArgs e) {
      var row = DataGridViewSelections.SelectedRows[0];

      if (row.Tag is not StudentSelection selection) {
        throw new InvalidCastException("In dieser Zeile war keine Schülerauswahl.");
      }

      StudentSelection? newSelection = null;

      using (var dialogue = new FormEditStudentSelection(selection, _subjects)) {
        if (dialogue.ShowDialog() == DialogResult.OK) {
          newSelection = dialogue.GetNewSelection();
          row.Tag = newSelection;
        }
      }

      if (newSelection is not null) {
        _selections.Remove(selection);
        _selections.Add(newSelection);
        _selections.FillDataGridView(DataGridViewSelections);
      }

      EnableButtons();
    }

    private void ButtonClose_Click(object sender, EventArgs e) {
      Close();
    }

    private void DataGridViewSelections_SelectionChanged(object sender, EventArgs e) {
      EnableButtons();
    }

    private void FormStudentSelectionResults_Load(object sender, EventArgs e) {
      EnableButtons();
      _selections.FillDataGridView(DataGridViewSelections);
    }
  }
}
