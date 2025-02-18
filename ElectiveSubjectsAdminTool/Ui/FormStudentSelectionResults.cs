namespace ElectiveSubjectsAdminTool.Ui
{
  public partial class FormStudentSelectionResults : Form
  {
    private StudentSelectionCollection? _selections;
    private SubjectCollection? _subjects;

    public FormStudentSelectionResults() {
      InitializeComponent();
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
      ButtonEdit.Enabled = _selections is not null && 
        _subjects is not null && 
        DataGridViewSelections.SelectedRows.Count == 1;

      ButtonExport.Enabled = _selections is not null && 
        _subjects is not null && 
        _selections.Count > 0;
    }

    private void ButtonEdit_Click(object sender, EventArgs e) {
      ArgumentNullException.ThrowIfNull(_selections);
      ArgumentNullException.ThrowIfNull(_subjects);

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

    private void LoadSelectionFile() {
      DialogResult? dialogueResult = null;
      var path = string.Empty;

      using (var fileDialogue = new OpenFileDialog()) {
        fileDialogue.RestoreDirectory = true;
        fileDialogue.Filter = "JSON-Dateien (*.json)|*.json|Alle Dateien (*.*)|*.*";
        fileDialogue.Multiselect = false;
        dialogueResult = fileDialogue.ShowDialog();
        path = fileDialogue.FileName;
      }

      if (dialogueResult == DialogResult.OK) {
        if (StudentSelectionCollection(path, out var error, out var students)) {
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

    private void FormStudentSelectionResults_Load(object sender, EventArgs e) {
      EnableButtons();
      _selections.FillDataGridView(DataGridViewSelections);
    }
  }
}
