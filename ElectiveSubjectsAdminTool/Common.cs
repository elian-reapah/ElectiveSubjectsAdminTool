namespace ElectiveSubjectsAdminTool
{
  public static class Common
  {
    public static bool TryGetJobType(string text, out JobType type) {
      type = JobType.None;

      if (text.StartsWith("FIA", StringComparison.Ordinal)) {
        type = JobType.Fachinformatiker_Anwendungsentwicklung;
      } else if (text.StartsWith("FIS", StringComparison.Ordinal)) {
        type = JobType.Fachinformatiker_Systemintegration;
      } else if (text.StartsWith("FIP", StringComparison.Ordinal)) {
        type = JobType.Fachinformatiker_Daten_Prozessanalyse;
      } else if (text.StartsWith("SE", StringComparison.Ordinal)) {
        type = JobType.IT_System_Elektroniker;
      } else if (text.StartsWith("KDM", StringComparison.Ordinal)) {
        type = JobType.Kaufmann_Digitalisierungsmanagement;
      } else if (text.StartsWith("KSM", StringComparison.Ordinal)) {
        type = JobType.Kaufmann_IT_System_Management;
      }

      return type != JobType.None;
    }

    public static string GetJobTypeShowText(JobType type) {
      switch (type) {
        case JobType.Fachinformatiker_Anwendungsentwicklung:
          return "Fachinformatiker Anwendungsentwicklung";

        case JobType.Fachinformatiker_Systemintegration:
          return "Fachinformatiker Systemintegration";

        case JobType.Fachinformatiker_Daten_Prozessanalyse:
          return "Fachinformatiker Daten - und Prozessanalyse";

        case JobType.IT_System_Elektroniker:
          return "IT-System-Elektroniker";

        case JobType.Kaufmann_Digitalisierungsmanagement:
          return "Kaufleute für Digitalisierungsmanagement";

        case JobType.Kaufmann_IT_System_Management:
          return "Kaufleute für IT-System-Management";

        default:
          throw new InvalidOperationException("Es handelt sich um einen ungültigen Ausbildungstyp.");
      }
    }

    public static string GetIndentString(int indentLevel) {
      return new string(' ', indentLevel * 2);
    }
  }
}
