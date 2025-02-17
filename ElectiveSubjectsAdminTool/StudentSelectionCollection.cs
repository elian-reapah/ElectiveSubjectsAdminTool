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
      result.Add("ID;Vorname;Nachname;Erste Wahl;Zweite Wahl;Dritte Wahl");

      foreach (var selection in _elements) {
        var row = new[] {
          selection.Student.Id.ToString(),
          selection.Student.FirstName,
          selection.Student.LastName,
          selection.FirstChoice.Name,
          selection.SecondChoice.Name,
          selection.ThirdChoice.Name
        };

        result.Add(string.Join(';', row));
      }

      return result.ToArray();
    }
  }
}
