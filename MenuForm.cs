namespace TodoList;

public partial class MenuForm : Form
{
    public MenuForm()
    {
        InitializeComponent();
    }

    public void CreateTodoButton_Click(object sender, EventArgs e)
    {
        var createTodoForm = new CreateTodoForm();
        createTodoForm.Show();
    }
}