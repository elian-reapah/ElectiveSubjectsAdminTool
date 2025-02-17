using System.Security;
using System.Text.Json.Nodes;

namespace ElectiveSubjectsAdminTool
{
  public static class FileHelp
  {
    public static bool TryGetLinesFromFile(string path, out string[]? lines, out string? error) {
      var resultLines = Array.Empty<string>();
      error = null;

      try {
        resultLines = File.ReadAllLines(path);
      } catch (PathTooLongException) {
        error = "Der Dateipfad ist zu lang.";
      } catch (DirectoryNotFoundException) {
        error = "Einer der Ordner konnte nicht gefunden werden.";
      } catch (FileNotFoundException) {
        error = "Die Datei konnte nicht gefunden werden.";
      } catch (IOException) {
        error = "Es gab einen Fehler beim öffnen der Datei.";
      } catch (SecurityException) {
        error = "Sie haben nicht die benötigten Berechtigungen um diese Datei zu öffnen.";
      } catch (NotSupportedException) {
        error = "Der Dateipfad ist in keinem bekannten Format.";
      }

      if (resultLines.Length == 0) {
        lines = null;
        return false;
      }

      lines = resultLines;
      return true;
    }

    public static bool TryCreateFile(string path, string[] lines, out string? error) {
      error = null;

      try {
        File.AppendAllLines(path, lines);
      } catch (PathTooLongException) {
        error = "Der Dateipfad ist zu lang.";
      } catch (DirectoryNotFoundException) {
        error = "Einer der Ordner konnte nicht gefunden werden.";
      } catch (FileNotFoundException) {
        error = "Die Datei konnte nicht gefunden werden.";
      } catch (IOException) {
        error = "Es gab einen Fehler beim öffnen der Datei.";
      } catch (SecurityException) {
        error = "Sie haben nicht die benötigten Berechtigungen um diese Datei zu öffnen.";
      } catch (NotSupportedException) {
        error = "Der Dateipfad ist in keinem bekannten Format.";
      }

      return error is null;
    }

    public static bool TryCreateJsonFile(string path, string[] jsonLines, out string? error) {
      var lines = new List<string>();
      lines.Add("{");
      lines.AddRange(jsonLines);
      lines.Add("}");

      return TryCreateFile(path, lines.ToArray(), out error);
    }

    public static JsonNode? GetJsonFromFile(string path) {
      using (var stream = File.OpenRead(path)) {
        return JsonNode.Parse(stream);
      }
    }
  }
}
