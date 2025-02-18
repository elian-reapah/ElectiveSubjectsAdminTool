namespace ElectiveSubjectsAdminTool.Ui
{
  public partial class FormEditStudentSelection : Form
  {
    private readonly StudentSelection _selection;
    private readonly SubjectCollection _subjects;
    private Subject? _newFirstChoice;
    private Subject? _newSecondChoice;
    private Subject? _newThirdChoice;

    public FormEditStudentSelection(StudentSelection selection, SubjectCollection subjects) {
      InitializeComponent();
      _selection = selection;
      _subjects = subjects;
    }

    private void FormEditStudentSelection_Load(object sender, EventArgs e) {
      LabelId.Text = "ID: " + _selection.Id.ToString();
      FillComboBoxes();
    }

    private void FillComboBoxes() {
      var boxes = new[] {
        ComboBoxFirstChoice,
        ComboBoxSecondChoice,
        ComboBoxThirdChoice
      };

      for (var i = 0; i < boxes.Length; i++) {
        foreach (var subject in _subjects.Elements) {
          var index = boxes[i].Items.Add(new ComboBoxItem<Subject>(subject.Name, subject));

          if (i == 0 && subject == _selection.FirstChoice) {
            _newFirstChoice = subject;
            boxes[i].SelectedIndex = index;
          } else if (i == 1 && subject == _selection.SecondChoice) {
            _newSecondChoice = subject;
            boxes[i].SelectedIndex = index;
          } else if (i == 2 && subject == _selection.ThirdChoice) {
            _newThirdChoice = subject;
            boxes[i].SelectedIndex = index;
          }
        }
      }
    }

    public StudentSelection GetNewSelection() {
      ArgumentNullException.ThrowIfNull(_newFirstChoice);
      ArgumentNullException.ThrowIfNull(_newSecondChoice);
      ArgumentNullException.ThrowIfNull(_newThirdChoice);

      return new StudentSelection(_selection.Id,
        _newFirstChoice,
        _newSecondChoice,
        _newThirdChoice);
    }

    private void ButtonDone_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.OK;
      Close();
    }

    private void ButtonCancel_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    private void ComboBoxFirstChoice_SelectedIndexChanged(object sender, EventArgs e) {
      if (ComboBoxFirstChoice.SelectedItem is not ComboBoxItem<Subject> item) {
        throw new InvalidCastException("In der ComboBox war ein invalides Item.");
      }

      _newFirstChoice = item.Tag;
    }

    private void ComboBoxSecondChoice_SelectedIndexChanged(object sender, EventArgs e) {
      if (ComboBoxSecondChoice.SelectedItem is not ComboBoxItem<Subject> item) {
        throw new InvalidCastException("In der ComboBox war ein invalides Item.");
      }

      _newSecondChoice = item.Tag;
    }

    private void ComboBoxThirdChoice_SelectedIndexChanged(object sender, EventArgs e) {
      if (ComboBoxThirdChoice.SelectedItem is not ComboBoxItem<Subject> item) {
        throw new InvalidCastException("In der ComboBox war ein invalides Item.");
      }

      _newThirdChoice = item.Tag;
    }
  }
}
