namespace TodoList;

public partial class AllTodosForm : Form
{
    public AllTodosForm()
    {
        InitializeComponent();

        TodoTypeCombobox.SelectedIndex = (int)TodoType.SHOPPING;
        RenderTodos(TodoType.SHOPPING);
    }

    private void CreateCommonColumns()
    {
        TodosListView.Columns.AddRange(new ColumnHeader[] { IdColumn, TitleColumn, CompletedColumn });
    }

    static private ListViewItem GetCommonViewItem(Todo todo)
    {
        var item = new ListViewItem(todo.Id);

        item.SubItems.AddRange(new string[] { todo.Title, todo.Completed ? "Tak" : "Nie" });

        return item;
    }

    private void RenderShoppingTodos()
    {
        var todos = TodoShopping.GetAllFromDb();

        AdditionalColumn.Text = "Nazwa produktu";
        TodosListView.Columns.AddRange(new ColumnHeader[] { AdditionalColumn, PriceColumn });

        todos.ForEach(todo =>
        {
            var item = GetCommonViewItem(todo);
            item.SubItems.Add(todo.ProductName);
            item.SubItems.Add(todo.ProductPrice.ToString());

            TodosListView.Items.Add(item);
        });
    }

    private void RenderWorkTodos()
    {
        var todos = TodoWork.GetAllFromDb();

        AdditionalColumn.Text = "Firma";
        TodosListView.Columns.Add(AdditionalColumn);

        todos.ForEach(todo =>
        {
            var item = GetCommonViewItem(todo);
            item.SubItems.Add(todo.Company);

            TodosListView.Items.Add(item);
        });
    }

    private void RenderSchoolTodos()
    {
        var todos = TodoSchool.GetAllFromDb();

        AdditionalColumn.Text = "Przedmiot";
        TodosListView.Columns.Add(AdditionalColumn);

        todos.ForEach(todo =>
        {
            var item = GetCommonViewItem(todo);
            item.SubItems.Add(todo.Subject);

            TodosListView.Items.Add(item);
        });
    }

    private void RenderTodos(TodoType todoType)
    {
        TodosListView.Clear();
        CreateCommonColumns();

        switch (todoType)
        {
            case TodoType.SHOPPING:
                RenderShoppingTodos();
                break;
            case TodoType.SCHOOL:
                RenderSchoolTodos();
                break;
            case TodoType.WORK:
                RenderWorkTodos();
                break;
            default:
                MessageBox.Show("Nieoczekiwany problem. Wybrano nieprawidłowy rodzaj zadania.");
                break;
        }
    }

    private TodoType GetSelectedTodoType()
    {
        return (TodoType)TodoTypeCombobox.SelectedIndex;
    }

    private void TodoTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
        RenderTodos(GetSelectedTodoType());
    }

    private void TodosListView_Click(object sender, EventArgs e)
    {
        var selectedTodoType = GetSelectedTodoType();

        var id = TodosListView.SelectedItems[0].Text;
        var form = new UpsertTodoForm(id, selectedTodoType, () => RenderTodos(selectedTodoType));
        form.Show();
    }
}
