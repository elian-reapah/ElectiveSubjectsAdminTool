using ElectiveSubjectsAdminTool.Ui;

namespace ElectiveSubjectsAdminTool
{
  public partial class FormConfigurateTemplate : Form
  {
    private SubjectCollection _subjects = new();
    private readonly StudentCollection _students;

    public FormConfigurateTemplate(StudentCollection students) {
      InitializeComponent();
      _students = students;
    }

    private void FormConfigurateSubjects_Load(object sender, EventArgs e) {
      _students.FillDataGridView(DataGridViewStudents);
      _subjects.FillDataGridView(DataGridViewSubjects);
      EnableButtons();
    }

    private void EnableButtons() {
      ButtonCreateTemplate.Enabled = _subjects.Count > 0 && _students.Count > 0;
      ButtonRemoveStudent.Enabled = DataGridViewStudents.SelectedRows.Count > 0;
      ButtonRemoveSubject.Enabled = DataGridViewSubjects.SelectedRows.Count > 0;
      ButtonSaveSubjects.Enabled = _subjects.Count > 0;
    }

    private void ButtonAddStudent_Click(object sender, EventArgs e) {
      Student? student = null;

      using (var dialogue = new FormConfigurateStudent()) {
        dialogue.StartPosition = FormStartPosition.CenterParent;

        if (dialogue.ShowDialog() == DialogResult.OK) {
          student = dialogue.GetStudent();
        }
      }

      if (student is not null) {
        _students.Add(student);
        _students.FillDataGridView(DataGridViewStudents);
        SelectElement<Student>(student, DataGridViewStudents);
      }

      EnableButtons();
    }

    private static void SelectElement<T>(T element, DataGridView view) where T : Element {
      foreach (DataGridViewRow row in view.Rows) {
        if (row.Tag is not T rowElement) {
          throw new InvalidCastException("In dieser Zeile war kein Schüler-Objekt.");
        }

        row.Selected = rowElement == element;
      }
    }

    private void ButtonAddSubject_Click(object sender, EventArgs e) {
      Subject? subject = null;

      using (var dialogue = new FormConfigurateSubject()) {
        dialogue.StartPosition = FormStartPosition.CenterParent;

        if (dialogue.ShowDialog() == DialogResult.OK) {
          subject = dialogue.GetSubject();
        }
      }

      if (subject is not null) {
        _subjects.Add(subject);
        _subjects.FillDataGridView(DataGridViewSubjects);
        SelectElement<Subject>(subject, DataGridViewSubjects);
      }

      EnableButtons();
    }

    private void ButtonRemoveSubject_Click(object sender, EventArgs e) {
      foreach (DataGridViewRow row in DataGridViewSubjects.SelectedRows) {
        if (row.Tag is not Subject subject) {
          throw new InvalidCastException("In dieser Zeile war kein Fach-Objekt.");
        }

        _subjects.Remove(subject);
      }

      _subjects.FillDataGridView(DataGridViewSubjects);
      EnableButtons();
    }

    private void ButtonCreateTemplate_Click(object sender, EventArgs e) {
      CreateJsonFile(Template.CreateJsonLines(_students, _subjects), "web_vorlage");
      EnableButtons();
    }

    private static void CreateJsonFile(string[] jsonLines, string fileName) {
      var now = DateTime.Now;
      string? folderPath = null;

      using (var dialogue = new FolderBrowserDialog()) {
        dialogue.Multiselect = false;

        if (dialogue.ShowDialog() == DialogResult.OK) {
          folderPath = dialogue.SelectedPath;
        }
      }

      if (folderPath is not null) {
        var file = fileName + "_" + now.ToString("dd_MM_yyyy") + ".json";
        var path = Path.Combine(folderPath, file);

        if (FileHelp.TryCreateJsonFile(path, jsonLines, out var error)) {
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

    private void ButtonCancel_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    private void ButtonRemoveStudent_Click(object sender, EventArgs e) {
      foreach (DataGridViewRow row in DataGridViewStudents.SelectedRows) {
        if (row.Tag is not Student student) {
          throw new InvalidCastException("In dieser Zeile war kein Schüler-Objekt.");
        }

        _students.Remove(student);
      }

      _students.FillDataGridView(DataGridViewStudents);
      EnableButtons();
    }

    private void ButtonSaveSubjects_Click(object sender, EventArgs e) {
      CreateJsonFile(_subjects.GetAsJsonLines(1, true), "wahlpflichtfaecher");
      EnableButtons();
    }

    private void ButtonLoadSubjects_Click(object sender, EventArgs e) {
      var messageBoxDialogueResult = DialogResult.Yes;
      
      if (_subjects.Count > 0) {
        messageBoxDialogueResult = MessageBox.Show("Es werden alle bisherigen Fächer gelöscht. Trotzdem fortfahren?",
        "Achtung!",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);
      }

      if (messageBoxDialogueResult == DialogResult.Yes) {
        DialogResult? dialogueResult = null;
        var path = string.Empty;

        using (var fileDialogue = new OpenFileDialog()) {
          fileDialogue.RestoreDirectory = true;
          fileDialogue.Filter = "Json-Dateien (*.json)|*.json|Alle Dateien (*.*)|*.*";
          fileDialogue.Multiselect = false;
          dialogueResult = fileDialogue.ShowDialog();
          path = fileDialogue.FileName;
        }

        if (Path.GetExtension(path).Equals(".json", StringComparison.OrdinalIgnoreCase)) {
          if (SubjectCollection.TryLoadFromJson(path, out var subjects)) {
            ArgumentNullException.ThrowIfNull(subjects);

            _subjects = subjects;
            _subjects.FillDataGridView(DataGridViewSubjects);
          } else {
            MessageBox.Show("Die Json-Datei konnte nicht verarbeitet werden.",
              "Achtung!",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
          }
        } else { 
          MessageBox.Show("Es handelt sich nicht um eine Json-Datei.", 
            "Achtung!", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Error);
        }
      }

      EnableButtons();
    }

    public StudentCollection GetStudents() {
      return _students;
    }

    public SubjectCollection GetSubjects() {
      return _subjects;
    }
  }
}
