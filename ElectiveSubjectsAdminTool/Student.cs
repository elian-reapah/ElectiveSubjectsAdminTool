namespace ElectiveSubjectsAdminTool
{
  public sealed class Student : Element
  {
    public int Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public JobType JobType { get; }

    public Student(int id, string firstName, string lastName, JobType jobType) {
      Id = id;
      FirstName = firstName;
      LastName = lastName;
      JobType = jobType;
    }

    public static bool TryCreateFromLine(string line, out Student? student) {
      var split = line.Split(';');

      if (split.Length != 4) {
        student = null;
        return false;
      }

      var jobTypeText = split[0];
      var firstName = split[1];
      var lastName = split[2];
      var idText = split[3];

      if (string.IsNullOrEmpty(firstName) || 
        string.IsNullOrEmpty(lastName) || 
        !int.TryParse(idText, out var id) || 
        !Common.TryGetJobType(jobTypeText, out var jobType)) {
        student = null;
        return false;
      }

      student = new Student(id, firstName, lastName, jobType);
      return true;
    }

    public override void AddToDataGridView(DataGridView view) {
      var row = new DataGridViewRow() { Tag = this };
      var idCell = new DataGridViewTextBoxCell() { Value = Id.ToString() };
      var firstNameCell = new DataGridViewTextBoxCell() { Value = FirstName };
      var lastNameCell = new DataGridViewTextBoxCell() { Value = LastName };
      var jobTypeCell = new DataGridViewTextBoxCell() { Value = Common.GetJobTypeShowText(JobType) };

      row.Cells.Add(idCell);
      row.Cells.Add(firstNameCell);
      row.Cells.Add(lastNameCell);
      row.Cells.Add(jobTypeCell);

      idCell.ReadOnly = true;
      firstNameCell.ReadOnly = true;
      lastNameCell.ReadOnly = true;
      jobTypeCell.ReadOnly = true;

      view.Rows.Add(row);
    }
  }
}
