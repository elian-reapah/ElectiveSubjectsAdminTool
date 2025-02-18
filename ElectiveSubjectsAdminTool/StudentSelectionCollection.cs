namespace ElectiveSubjectsAdminTool
{
  public sealed class StudentSelectionCollection : ElementCollection<StudentSelection>
  {
    private static DataGridViewColumn[] GetDataGridViewColumns() {
      return new[] {
        new DataGridViewColumn() {
          CellTemplate = new DataGridViewTextBoxCell(),
          HeaderText = "ID",
          ReadOnly = true,
        },
        new DataGridViewColumn() {
          CellTemplate = new DataGridViewTextBoxCell(),
          HeaderText = "1. Wahl",
          ReadOnly = true,
        },
        new DataGridViewColumn() {
          CellTemplate = new DataGridViewTextBoxCell(),
          HeaderText = "2. Wahl",
          ReadOnly = true,
        },
        new DataGridViewColumn() {
          CellTemplate = new DataGridViewTextBoxCell(),
          HeaderText = "3. Wahl",
          ReadOnly = true,
        },
      };
    }

    public override void FillDataGridView(DataGridView view) {
      view.Columns.Clear();
      view.Columns.AddRange(GetDataGridViewColumns());

      view.Rows.Clear();

      foreach (var selection in _elements) {
        selection.AddToDataGridView(view);
      }
    }

    public string[] GetAsCsvLines() {
      var result = new List<string>();
      result.Add("ID;Erste Wahl;Zweite Wahl;Dritte Wahl");

      foreach (var selection in _elements) {
        var row = new[] {
          selection.Id.ToString(),
          selection.FirstChoice.Name,
          selection.SecondChoice.Name,
          selection.ThirdChoice.Name
        };

        result.Add(string.Join(';', row));
      }

      return result.ToArray();
    }

    public static bool TryLoadFromJson(string path, Dictionary<int, Subject> subjects, out StudentSelectionCollection? selections) {
      var root = FileHelp.GetJsonFromFile(path);

      if (root is null) {
        selections = null;
        return false;
      }

      var rootObject = root.AsObject();

      if (!rootObject.ContainsKey("studentList")) {
        selections = null;
        return false;
      }

      var result = new StudentSelectionCollection();

      foreach (var node in rootObject.AsArray()) {
        if (node is not null &&
          StudentSelection.TryGetFromJson(node, subjects, out var selection)) {
          ArgumentNullException.ThrowIfNull(selection);
          result.Add(selection);
        }
      }

      selections = result;
      return true;
    }
  }
}
