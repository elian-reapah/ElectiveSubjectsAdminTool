namespace ElectiveSubjectsAdminTool
{
  public static class Program
  {
    [STAThread]
    public static void Main() {
      ApplicationConfiguration.Initialize();
      Application.Run(new FormMain());
    }
  }
}