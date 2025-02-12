namespace ElectiveSubjectsAdminTool
{
  public sealed class Student : Element
  {
    public int Id { get; }
    public string FirstName { get; }
    public string LastName { get; }

    public Student(int id, string firstName, string lastName) {
      Id = id;
      FirstName = firstName;
      LastName = lastName;
    }

    public static bool TryCreateFromLine(string line, out Student? student) {
      var split = line.Split(';');

      if (split.Length != 13) {
        student = null;
        return false;
      }

      var firstName = split[0];
      var lastName = split[1];
      var idText = split[^1];

      if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || 
        !int.TryParse(idText, out var id)) {
        student = null;
        return false;
      }

      student = new Student(id, firstName, lastName);
      return true;
    }

    public override void AddToDataGridView(DataGridView view) {
      var row = new DataGridViewRow() { Tag = this };
      var idCell = new DataGridViewTextBoxCell() { Value = Id.ToString() };
      var firstNameCell = new DataGridViewTextBoxCell() { Value = FirstName };
      var lastNameCell = new DataGridViewTextBoxCell() { Value = LastName };

      row.Cells.Add(idCell);
      row.Cells.Add(firstNameCell);
      row.Cells.Add(lastNameCell);

      idCell.ReadOnly = true;
      firstNameCell.ReadOnly = true;
      lastNameCell.ReadOnly = true;

      view.Rows.Add(row);
    }
  }
}
