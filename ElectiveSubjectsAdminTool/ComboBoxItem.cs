namespace ElectiveSubjectsAdminTool
{
  public sealed class ComboBoxItem<T>
  {
    public string Text { get; }
    public T Tag { get; }

    public ComboBoxItem(string text, T tag) {
      Text = text;
      Tag = tag;
    }

    // Gibt den Text an der im DataGridView angezeigt wird
    public override string ToString() {
      return Text;
    }
  }
}
