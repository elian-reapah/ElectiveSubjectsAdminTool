using ElectiveSubjectsAdminTool.Ui;

namespace ElectiveSubjectsAdminTool
{
  public partial class FormConfigurateTemplate : Form
  {
    private readonly SubjectCollection _subjects = new();
    private readonly StudentCollection _students;

    public FormConfigurateTemplate(StudentCollection students) {
      InitializeComponent();
      _students = students;
    }

    private void FormConfigurateSubjects_Load(object sender, EventArgs e) {

    }

    private void EnableButtons() {
      ButtonCreateTemplate.Enabled = _subjects.Count > 0;
      ButtonRemoveStudent.Enabled = DataGridViewStudents.SelectedRows.Count > 0;
      ButtonRemoveSubject.Enabled = DataGridViewSubjects.SelectedRows.Count > 0;
    }

    private void ButtonAddStudent_Click(object sender, EventArgs e) {
      var dialogue = new FormConfigurateStudent();
      dialogue.StartPosition = FormStartPosition.CenterParent;

      if (dialogue.ShowDialog() == DialogResult.OK) {
        var student = dialogue.GetStudent();
        _students.Add(student);
        _students.FillDataGridView(DataGridViewStudents);
        SelectElement<Student>(student, DataGridViewStudents);
      }

      EnableButtons();
    }

    private static void SelectElement<T>(T element, DataGridView view) where T : Element {
      foreach (DataGridViewRow row in view.Rows) {
        if (row.Tag is not T rowElement) {
          throw new InvalidCastException("In dieser Zeile war kein Schüler-Objekt.");
        }

        row.Selected = rowElement == element;
      }
    }

    private void ButtonAddSubject_Click(object sender, EventArgs e) {
      var dialogue = new FormConfigurateSubject();
      dialogue.StartPosition = FormStartPosition.CenterParent;

      if (dialogue.ShowDialog() == DialogResult.OK) {
        var subject = dialogue.GetSubject();
        _subjects.Add(subject);
        _subjects.FillDataGridView(DataGridViewSubjects);
        SelectElement<Subject>(subject, DataGridViewSubjects);
      }

      EnableButtons();
    }

    private void ButtonRemoveSubject_Click(object sender, EventArgs e) {

    }

    private void ButtonCreateTemplate_Click(object sender, EventArgs e) {

    }

    private void ButtonLoadSelectionResults_Click(object sender, EventArgs e) {

    }

    private void ButtonCancel_Click(object sender, EventArgs e) {

    }
  }
}
