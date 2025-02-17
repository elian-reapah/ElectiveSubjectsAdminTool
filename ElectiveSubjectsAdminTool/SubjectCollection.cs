using System.Text.Json.Nodes;

namespace ElectiveSubjectsAdminTool
{
  public sealed class SubjectCollection : ElementCollection<Subject>
  {
    public static bool TryLoadFromJson(string path, out SubjectCollection? subjects) {
      var root = FileHelp.GetJsonFromFile(path);

      if (root is null) {
        subjects = null;
        return false;
      }

      var rootObject = root.AsObject();

      if (!rootObject.ContainsKey("subjects")) {
        subjects = null;
        return false;
      }

      var result = new SubjectCollection();

      foreach (var node in rootObject.AsArray()) {
        if (node is not null && 
          Subject.TryGetFromJsonNode(node, out var subject)) {
          ArgumentNullException.ThrowIfNull(subject);

          result.Add(subject);
        }
      }

      subjects = result;
      return true;
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

    public string[] GetAsJsonLines(int indentLevel, bool isOnlyElement) {
      var result = new List<string>();
      result.Add(Common.GetIndentString(indentLevel) + "subjects: [");

      for (var i = 0; i < _elements.Count; i++) {
        result.AddRange(_elements[i].GetAsJsonLines(indentLevel + 1, i == _elements.Count - 1));
      }

      var text = Common.GetIndentString(indentLevel) + "]";

      if (!isOnlyElement) {
        text += ",";
      }

      result.Add(text);
      return result.ToArray();
    }
  }
}
