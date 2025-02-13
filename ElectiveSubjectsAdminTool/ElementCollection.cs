namespace ElectiveSubjectsAdminTool
{
  public abstract class ElementCollection<T> where T : Element
  {
    protected readonly List<T> _elements = new();

    public int Count {
      get {
        return _elements.Count;
      }
    }

    public void Add(T element) {
      _elements.Add(element);
    }

    public void Remove(T element) {
      _elements.Remove(element);
    }

    public abstract void FillDataGridView(DataGridView view);
    public abstract string[] GetAsJsonLines(int indentLevel);
  }
}
