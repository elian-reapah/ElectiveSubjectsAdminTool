using ElectiveSubjectsAdminTool.Ui;

namespace ElectiveSubjectsAdminTool
{
  public static class Program
  {
    [STAThread]
    public static void Main() {
      ApplicationConfiguration.Initialize();
      StudentCollection? students = null;

      using (var dialogue = new FormStudentsInsert()) {
        if (dialogue.ShowDialog() == DialogResult.OK) {
          students = dialogue.GetStudents();
        }
      }

      SubjectCollection? subjects = null;

      if (students is not null) {
        using (var dialogue = new FormConfigurateTemplate(students)) {
          if (dialogue.ShowDialog() == DialogResult.Continue) {
            students = dialogue.GetStudents();
            subjects = dialogue.GetSubjects();
          }
        }
      }

      if (subjects is not null) {
        // Selection Collection hier per Json erstellen
        using (var dialogue = new FormStudentSelectionResults(null, subjects)) {
          dialogue.ShowDialog();
        }
      }
    }
  }
}