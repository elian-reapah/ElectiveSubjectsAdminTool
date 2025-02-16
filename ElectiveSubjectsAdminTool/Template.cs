namespace ElectiveSubjectsAdminTool
{
  public sealed class Template
  {
    private readonly Dictionary<string, Student> _studentsWithToken;
    private readonly Random _random;
    private readonly char[] _letters;

    private Template() {
      _studentsWithToken = new();
      _random = new Random();
      _letters = new char[50];
      var index = 0;

      for (var i = 97; i <= 122; i++) {
        var c = (char)i;
        _letters[index] = c;
        _letters[index + 1] = char.ToUpperInvariant(c);
        index = index + 2;
      }
    }

    public static string[] CreateJsonLines(StudentCollection students, SubjectCollection subjects) {
      var result = new List<string>();
      result.AddRange(subjects.GetAsJsonLines(1, false));

      var template = new Template();

      foreach (var student in students.Elements) {
        template.GenerateTokenForStudent(student);
      }

      result.AddRange(template.GetStudentJsonLines());
      return result.ToArray();
    }

    private string[] GetStudentJsonLines() {
      var result = new List<string>();
      result.Add(Common.GetIndentString(1) + "\"students\": [");

      var count = 0;

      foreach ((var token, var student) in _studentsWithToken) {
        result.Add(Common.GetIndentString(2) + "{");
        result.Add(Common.GetIndentString(3) + "\"id\": \"" + student.Id + "\",");
        result.Add(Common.GetIndentString(3) + "\"token\": \"" + token + "\",");

        var lastLine = Common.GetIndentString(2) + "}";

        if (count != _studentsWithToken.Count - 1) {
          lastLine += ",";
        }

        result.Add(lastLine);
        count++;
      }

      result.Add(Common.GetIndentString(1) + "]");
      return result.ToArray();
    }

    private void GenerateTokenForStudent(Student student) {
      var token = string.Empty;

      do {
        var letters = string.Empty;
        var digits = string.Empty;

        for (var i = 0; i < 4; i++) {
          letters += _letters[_random.Next(0, _letters.Length)];
          digits += _random.Next(0, 10).ToString();
        }

        token = letters + digits;
      } while (_studentsWithToken.ContainsKey(token));

      _studentsWithToken.Add(token, student);
    }
  }
}
