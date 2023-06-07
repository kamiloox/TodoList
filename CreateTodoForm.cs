namespace TodoList;

public partial class CreateTodoForm : Form
{
    private TodoType GetSelectedTodoType()
    {
        return (TodoType)TodoTypeCombobox.SelectedIndex;
    }

    public CreateTodoForm()
    {
        InitializeComponent();
    }


    private void TodoTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
        ShowFieldsForSelectedTodoType();
    }

    private void CreateTodoButton_Click(object sender, EventArgs e)
    {
        try
        {
            CreateTodo();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
            MessageBox.Show("Nieoczekiwany błąd. Nie udało się stworzyć zadania, sprawdź poprawność danych i spróbuj ponownie");
        }
    }

    private void CreateTodo()
    {
        var title = TodoTitleTextbox.Text;
        var completed = TodoCompletedRadio.Checked;

        switch (GetSelectedTodoType())
        {
            case TodoType.WORK:
                var company = AdditionalTextbox.Text;
                var todoWork = new TodoWork(title, completed, company);
                ShowCreatedTodoInfo(todoWork.GetInfo());
                break;
            case TodoType.SCHOOL:
                var subject = AdditionalTextbox.Text;
                var todoSchool = new TodoSchool(title, completed, subject);
                ShowCreatedTodoInfo(todoSchool.GetInfo());
                break;
            case TodoType.SHOPPING:
                var productName = AdditionalTextbox.Text;
                var productPrice = PriceNumeric.Value;
                var todoShopping = new TodoShopping(title, completed, productName, (float)productPrice);
                ShowCreatedTodoInfo(todoShopping.GetInfo());
                break;
            default:
                MessageBox.Show("Nieznany rodzaj zadania. Spróbuj ponownie");
                break;
        }

        Close();
    }
    
    private void ShowCreatedTodoInfo(string info)
    {
        MessageBox.Show($"Stworzono zadanie\n\n{info}");
    }

    private void ShowFieldsForSelectedTodoType()
    {
        AdditionalPanel.Hide();
        PricePanel.Hide();

        switch (GetSelectedTodoType())
        {
            case TodoType.SHOPPING:
                ShowShoppingFields();
                break;
            case TodoType.WORK:
                ShowWorkFields();
                break;
            case TodoType.SCHOOL:
                ShowSchoolFields();
                break;
            default:
                MessageBox.Show("Nieznany rodzaj zadania. Spróbuj ponownie");
                break;
        }
    }

    public void ShowShoppingFields()
    {
        AdditionalPanel.Show();
        AdditionalLabel.Text = "Nazwa produktu";

        PriceNumeric.Maximum = int.MaxValue;
        PricePanel.Show();
    }

    public void ShowWorkFields()
    {
        AdditionalPanel.Show();
        AdditionalLabel.Text = "Nazwa firmy";
    }

    public void ShowSchoolFields()
    {
        AdditionalPanel.Show();
        AdditionalLabel.Text = "Nazwa przedmiotu";
    }
}
