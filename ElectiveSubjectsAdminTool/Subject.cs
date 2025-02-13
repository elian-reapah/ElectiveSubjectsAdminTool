namespace ElectiveSubjectsAdminTool
{
  public sealed class Subject : Element
  {
    public string Name { get; }
    public string Description { get; }

    public Subject(string name, string description) {
      Name = name;
      Description = description;
    }

    public override void AddToDataGridView(DataGridView view) {
      var row = new DataGridViewRow() { Tag = this };
      var nameCell = new DataGridViewTextBoxCell() { Value = Name };

      var descriptionCell = new DataGridViewTextBoxCell() { 
        Value = Description.Substring(0, 100) + "...",
        ToolTipText = Description,
      };
      
      row.Cells.Add(nameCell);
      row.Cells.Add(descriptionCell);

      nameCell.ReadOnly = true;
      descriptionCell.ReadOnly = true;
      
      view.Rows.Add(row);
    }

    public string[] GetAsJsonLines(int indentLevel) {
      return new[] { 
        Common.GetIndentString(indentLevel) + "{",
        Common.GetIndentString(indentLevel + 1) + "\"name\": \"" + Name + "\"",
        Common.GetIndentString(indentLevel + 1) + "\"description\": \"" + Description + "\"",
        Common.GetIndentString(indentLevel) + "},",
      };
    }
  }
}
