using ElectiveSubjectsAdminTool.Ui;

namespace ElectiveSubjectsAdminTool
{
  public static class Program
  {
    [STAThread]
    public static void Main() {
      ApplicationConfiguration.Initialize();

      var continueType = DialogueContinueType.None;

      using (var dialogue = new FormStart()) {
        _ = dialogue.ShowDialog();
        continueType = dialogue.GetDialogueContinueType();
      }

      switch (continueType) {
        case DialogueContinueType.GenerateTemplate:
          GenerateTemplate();
          break;

        case DialogueContinueType.SelectionResults:
          SelectionResults();
          break;

        case DialogueContinueType.None:
          break;

        default:
          throw new InvalidOperationException("Es handelt sich um einen unbekannten Dialog-Typ.");
      }
    }

    private static void GenerateTemplate() { 
      using (var)
    }

    private static void SelectionResults() { 
    
    }
  }
}