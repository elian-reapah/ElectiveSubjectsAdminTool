using System.Security;

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

      if (!TryGetLinesFromFile(path, out var lines, out error)) {
        students = null;
        return false;
      }

      ArgumentNullException.ThrowIfNull(lines);
      var result = new StudentCollection();

      for (var i = 0; i < lines.Length; i++) {
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

    private static bool TryGetLinesFromFile(string path, out string[]? lines, out string? error) {
      var resultLines = Array.Empty<string>();
      error = null;

      try {
        resultLines = File.ReadAllLines(path);
      } catch (PathTooLongException) {
        error = "Der Dateipfad ist zu lang.";
      } catch (DirectoryNotFoundException) {
        error = "Einer der Ordner konnte nicht gefunden werden.";
      } catch (FileNotFoundException) {
        error = "Die Datei konnte nicht gefunden werden.";
      } catch (IOException) {
        error = "Es gab einen Fehler beim öffnen der Datei.";
      } catch (SecurityException) {
        error = "Sie haben nicht die benötigten Berechtigungen um diese Datei zu öffnen.";
      } catch (NotSupportedException) {
        error = "Der Dateipfad ist in keinem bekannten Format.";
      }

      if (resultLines.Length == 0) {
        lines = null;
        return false;
      }

      lines = resultLines;
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
