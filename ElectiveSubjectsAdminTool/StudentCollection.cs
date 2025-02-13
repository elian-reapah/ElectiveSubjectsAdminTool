namespace ElectiveSubjectsAdminTool
{
  public sealed class StudentCollection : ElementCollection<Student>
  {
    public static bool TryCreateFromCsv(string path, out string? error, out StudentCollection? students) {
      if (string.IsNullOrEmpty(path) ||
        !Path.GetExtension(path).Equals(".csv", StringComparison.OrdinalIgnoreCase)) {
        students = null;
        error = "Es handelt sich nicht um eine CSV-Datei.";
        return false;
      }

      if (!FileHelp.TryGetLinesFromFile(path, out var lines, out error)) {
        students = null;
        return false;
      }

      ArgumentNullException.ThrowIfNull(lines);
      var result = new StudentCollection();

      //i = 1 --> 1. (Index 0) Zeile = Spaltenüberschriften
      for (var i = 1; i < lines.Length; i++) {
        if (!Student.TryCreateFromLine(lines[i], out var student)) {
          students = null;
          error = "Die Csv-Datei war fehlerhaft in Zeile: " + (i + 1).ToString() + ".";
          return false;
        }

        ArgumentNullException.ThrowIfNull(student);
        result.Add(student);
      }

      students = result;
      return true;
    }

    private static DataGridViewColumn[] GetDataGridViewColumns() {
      return new[] {
        new DataGridViewColumn() {
          CellTemplate = new DataGridViewTextBoxCell(),
          HeaderText = "ID",
          ReadOnly = true,
        },
        new DataGridViewColumn() {
          CellTemplate = new DataGridViewTextBoxCell(),
          HeaderText = "Vorname",
          ReadOnly = true,
        },
        new DataGridViewColumn() {
          CellTemplate = new DataGridViewTextBoxCell(),
          HeaderText = "Nachname",
          ReadOnly = true,
        },
        new DataGridViewColumn() {
          CellTemplate = new DataGridViewTextBoxCell(),
          HeaderText = "Beruf",
          ReadOnly = true,
        },
      };
    }

    public override void FillDataGridView(DataGridView view) {
      view.Columns.Clear();
      view.Columns.AddRange(GetDataGridViewColumns());

      view.Rows.Clear();

      foreach (var student in _elements) {
        student.AddToDataGridView(view);
      }
    }
  }
}
