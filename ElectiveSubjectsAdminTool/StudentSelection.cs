
namespace ElectiveSubjectsAdminTool
{
  public sealed class StudentSelection : Element
  {
    public Student Student { get; }
    public Subject FirstChoice { get; }
    public Subject SecondChoice { get; }
    public Subject ThirdChoice { get; }

    public StudentSelection(Student student, Subject first, Subject second, Subject third) {
      Student = student;
      FirstChoice = first;
      SecondChoice = second;
      ThirdChoice = third;
    }

    public override void AddToDataGridView(DataGridView view) {
      var row = new DataGridViewRow() { Tag = this };
      var idCell = new DataGridViewTextBoxCell() { Value = Student.Id.ToString() };
      var firstNameCell = new DataGridViewTextBoxCell() { Value = Student.FirstName };
      var lastNameCell = new DataGridViewTextBoxCell() { Value = Student.LastName };
      var firstChoiceCell = new DataGridViewTextBoxCell() { Value = FirstChoice.Name };
      var secondChoiceCell = new DataGridViewTextBoxCell() { Value = SecondChoice.Name };
      var thirdChoiceCell = new DataGridViewTextBoxCell() { Value = ThirdChoice.Name };

      row.Cells.Add(idCell);
      row.Cells.Add(firstNameCell);
      row.Cells.Add(lastNameCell);
      row.Cells.Add(firstChoiceCell);
      row.Cells.Add(secondChoiceCell);
      row.Cells.Add(thirdChoiceCell);

      idCell.ReadOnly = true;
      firstNameCell.ReadOnly = true;
      lastNameCell.ReadOnly = true;
      firstChoiceCell.ReadOnly = true;
      secondChoiceCell.ReadOnly = true;
      thirdChoiceCell.ReadOnly = true;

      view.Rows.Add(row);
    }
  }
}
