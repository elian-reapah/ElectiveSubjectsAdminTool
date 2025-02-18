using System.Text.Json.Nodes;

namespace ElectiveSubjectsAdminTool
{
  public sealed class Subject : Element
  {
    public string Name { get; }
    public string Description { get; }
    public string ImportantNote { get; }
    public string Teacher { get; }

    public Subject(string name, string description, string importantNote, string teacher) {
      Name = name;
      Description = description;
      ImportantNote = importantNote;
      Teacher = teacher;
    }

    public override void AddToDataGridView(DataGridView view) {
      var row = new DataGridViewRow() { Tag = this };
      var nameCell = new DataGridViewTextBoxCell() { Value = Name };

      var descriptionCell = new DataGridViewTextBoxCell() {
        Value = Description.Substring(0, 60) + "...",
        ToolTipText = Description,
      };

      var noteCell = new DataGridViewTextBoxCell() { Value = ImportantNote };
      var teacherCell = new DataGridViewTextBoxCell() { Value = Teacher };

      row.Cells.Add(nameCell);
      row.Cells.Add(descriptionCell);
      row.Cells.Add(noteCell);
      row.Cells.Add(teacherCell);

      nameCell.ReadOnly = true;
      descriptionCell.ReadOnly = true;
      noteCell.ReadOnly = true;
      teacherCell.ReadOnly = true;
      
      view.Rows.Add(row);
    }

    public string[] GetAsJsonLines(int indentLevel, bool isLastElement) {
      var lastLine = Common.GetIndentString(indentLevel) + "}";

      if (!isLastElement) {
        lastLine += ",";
      }

      return new[] { 
        Common.GetIndentString(indentLevel) + "{",
        Common.GetIndentString(indentLevel + 1) + "\"name\": \"" + Name + "\",",
        Common.GetIndentString(indentLevel + 1) + "\"description\": \"" + Description + "\"",
        Common.GetIndentString(indentLevel + 1) + "\"importantNote\": \"" + ImportantNote + "\"",
        Common.GetIndentString(indentLevel + 1) + "\"teacher\": \"" + Teacher + "\"",
        lastLine,
      };
    }

    public static bool TryGetFromJsonNode(JsonNode node, out Subject? subject) {
      var name = node["name"];
      var description = node["description"];
      var importantNote = node["description"];
      var teacher = node["teacher"];

      if (name is null || description is null || importantNote is null || teacher is null) {
        subject = null;
        return false;
      }

      subject = new Subject(name.GetValue<string>(), 
        description.GetValue<string>(), 
        importantNote.GetValue<string>(), 
        teacher.GetValue<string>());

      return true;
    }

    public static bool TryGetWithIdFromJson(string path, out Dictionary<int, Subject>? subjects) {
      var root = FileHelp.GetJsonFromFile(path);

      if (root is null) {
        subjects = null;
        return false;
      }

      var rootObject = root.AsObject();

      if (!rootObject.ContainsKey("subjectList")) {
        subjects = null;
        return false;
      }

      var result = new Dictionary<int, Subject>();

      foreach (var node in rootObject.AsArray()) {
        if (node is null) {
          subjects = null;
          return false;
        }

        var idNode = node["subjectId"];

        if (idNode is null || !TryGetFromJsonNode(node, out var subject)) {
          subjects = null;
          return false;
        }

        ArgumentNullException.ThrowIfNull(subject);
        result.Add(idNode.GetValue<int>(), subject);
      }

      subjects = result;
      return true;
    }
  }
}
