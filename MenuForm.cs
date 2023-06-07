namespace TodoList;

public partial class MenuForm : Form
{
    public MenuForm()
    {
        InitializeComponent();
    }

    public void CreateTodoButton_Click(object sender, EventArgs e)
    {
        var createTodoForm = new UpsertTodoForm();
        createTodoForm.Show();
    }

    private void ShowTodosButton_Click(object sender, EventArgs e)
    {
        var allTodosForm = new AllTodosForm();
        allTodosForm.Show();
    }
}