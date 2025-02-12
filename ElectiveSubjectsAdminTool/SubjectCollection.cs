namespace ElectiveSubjectsAdminTool
{
  public sealed class SubjectCollection : ElementCollection<Subject>
  {
    public override void FillDataGridView(DataGridView view) {
      view.Columns.Clear();

      var nameColumn = new DataGridViewColumn() {
        CellTemplate = new DataGridViewTextBoxCell(),
        HeaderText = "Name",
        ReadOnly = true,
      };

      var descriptionColumn = new DataGridViewColumn() {
        CellTemplate = new DataGridViewTextBoxCell(),
        HeaderText = "Beschreibung",
        ReadOnly = true,
      };

      view.Columns.Add(nameColumn);
      view.Columns.Add(descriptionColumn);

      view.Rows.Clear();

      foreach (var subject in _elements) {
        subject.AddToDataGridView(view);
      }
    }
  }
}
