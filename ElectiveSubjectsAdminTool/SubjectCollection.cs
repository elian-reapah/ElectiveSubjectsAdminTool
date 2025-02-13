using System.Text.Json.Nodes;

namespace ElectiveSubjectsAdminTool
{
  public sealed class SubjectCollection : ElementCollection<Subject>
  {
    public static SubjectCollection LoadFromJsonNode(JsonNode root) {

    }

    public override void FillDataGridView(DataGridView view) {
      view.Columns.Clear();

      var nameColumn = new DataGridViewColumn() {
        CellTemplate = new DataGridViewTextBoxCell(),
        HeaderText = "Name",
        ReadOnly = true,
      };

      var descriptionColumn = new DataGridViewColumn() {
        CellTemplate = new DataGridViewTextBoxCell(),
        HeaderText = "Beschreibung",
        ReadOnly = true,
      };

      view.Columns.Add(nameColumn);
      view.Columns.Add(descriptionColumn);

      view.Rows.Clear();

      foreach (var subject in _elements) {
        subject.AddToDataGridView(view);
      }
    }

    public override string[] GetAsJsonLines(int indentLevel) {
      var result = new List<string>();
      result.Add(Common.GetIndentString(indentLevel) + "subjects: [");

      foreach (var subject in _elements) {
        result.AddRange(subject.GetAsJsonLines(indentLevel + 1));
      }

      result.Add(Common.GetIndentString(indentLevel) + "],");
      return result.ToArray();
    }
  }
}
