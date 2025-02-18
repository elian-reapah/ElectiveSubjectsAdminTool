
using System.Text.Json.Nodes;

namespace ElectiveSubjectsAdminTool
{
  public sealed class StudentSelection : Element
  {
    public int Id { get; }
    public Subject FirstChoice { get; }
    public Subject SecondChoice { get; }
    public Subject ThirdChoice { get; }

    public StudentSelection(int id, Subject first, Subject second, Subject third) {
      Id = id;
      FirstChoice = first;
      SecondChoice = second;
      ThirdChoice = third;
    }

    public override void AddToDataGridView(DataGridView view) {
      var row = new DataGridViewRow() { Tag = this };
      var idCell = new DataGridViewTextBoxCell() { Value = Id.ToString() };
      var firstChoiceCell = new DataGridViewTextBoxCell() { Value = FirstChoice.Name };
      var secondChoiceCell = new DataGridViewTextBoxCell() { Value = SecondChoice.Name };
      var thirdChoiceCell = new DataGridViewTextBoxCell() { Value = ThirdChoice.Name };

      row.Cells.Add(idCell);
      row.Cells.Add(firstChoiceCell);
      row.Cells.Add(secondChoiceCell);
      row.Cells.Add(thirdChoiceCell);

      idCell.ReadOnly = true;
      firstChoiceCell.ReadOnly = true;
      secondChoiceCell.ReadOnly = true;
      thirdChoiceCell.ReadOnly = true;

      view.Rows.Add(row);
    }

    public static bool TryGetFromJson(JsonNode node, Dictionary<int, Subject> subjects, out StudentSelection? selection) {
      var idNode = node["studentId"];
      var firstChoiceNode = node["firstChoice"];
      var secondChoiceNode = node["secondChoice"];
      var thirdChoiceNode = node["thirdChoice"];

      if (idNode is null || firstChoiceNode is null || secondChoiceNode is null || thirdChoiceNode is null ||
        !subjects.TryGetValue(firstChoiceNode.GetValue<int>(), out var firstChoice) ||
        !subjects.TryGetValue(secondChoiceNode.GetValue<int>(), out var secondChoice) ||
        !subjects.TryGetValue(thirdChoiceNode.GetValue<int>(), out var thirdChoice)) {
        selection = null;
        return false;
      }

      selection = new StudentSelection(idNode.GetValue<int>(), firstChoice, secondChoice, thirdChoice);
      return true;
    }
  }
}
