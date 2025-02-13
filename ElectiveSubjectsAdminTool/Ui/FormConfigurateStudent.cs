namespace ElectiveSubjectsAdminTool
{
  public partial class FormConfigurateStudent : Form
  {
    private Student? _createdStudent;

    public FormConfigurateStudent() {
      InitializeComponent();
    }

    private void ButtonAccept_Click(object sender, EventArgs e) {
      if (ValidateInputs(out var errors)) {
        if (int.TryParse(TextBoxId.Text, out var id)) {
          _createdStudent = new Student(
            id, 
            TextBoxFirstName.Text, 
            TextBoxLastName.Text, 
            GetSelectedJobType());

          DialogResult = DialogResult.OK;
          Close();
        } else {
          MessageBox.Show("Die ID darf nur aus Zahlen bestehen.",
            "Achtung!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }
      } else {
        MessageBox.Show(string.Join(Environment.NewLine, errors),
          "Achtung!",
          MessageBoxButtons.OK,
          MessageBoxIcon.Warning);
      }
    }

    private JobType GetSelectedJobType() {
      if (ComboBoxJobType.SelectedItem is not ComboBoxItem item) {
        throw new InvalidCastException();
      }

      return item.Tag;
    }

    private bool ValidateInputs(out string[] errors) {
      var result = new List<string>();

      if (string.IsNullOrEmpty(TextBoxId.Text)) {
        result.Add("Die ID darf nicht leer sein.");
      }

      if (string.IsNullOrEmpty(TextBoxFirstName.Text)) {
        result.Add("Der Vorname darf nicht leer sein.");
      }

      if (string.IsNullOrEmpty(TextBoxLastName.Text)) {
        result.Add("Der Nachname darf nicht leer sein.");
      }

      errors = result.ToArray();
      return result.Count == 0;
    }

    private void ButtonCancel_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    public Student GetStudent() {
      ArgumentNullException.ThrowIfNull(_createdStudent);
      return _createdStudent;
    }

    private void FormConfigurateStudent_Load(object sender, EventArgs e) {
      foreach (var type in Enum.GetValues<JobType>()) {
        if (type != JobType.None) {
          ComboBoxJobType.Items.Add(new ComboBoxItem(Common.GetJobTypeShowText(type), type));
        }
      }
    }

    private sealed class ComboBoxItem { 
      public string Text { get; }
      public JobType Tag { get; }

      public ComboBoxItem(string text, JobType tag) {
        Text = text;
        Tag = tag;
      }

      public override string ToString() {
        return Text;
      }
    }
  }
}
