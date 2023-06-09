namespace TodoList;

enum FormType
{
    EDIT,
    CREATE
}

public partial class UpsertTodoForm : Form
{
    FormType FormType;

    readonly Action? OnSubmitFunction;
    readonly string? TodoId;

    private TodoType GetSelectedTodoType()
    {
        return (TodoType)TodoTypeCombobox.SelectedIndex;
    }

    // Initialize Form that edits existing todo
    public UpsertTodoForm(string todoId, TodoType todoType, Action onSubmit)
    {
        OnSubmitFunction = onSubmit;
        TodoId = todoId;

        InitializeComponent();

        AdjustToEditForm(todoType);

        ShowFieldsForSelectedTodoType();

        FillEditedTodo(todoId);
    }

    // Initialize Form that creates a new todo
    public UpsertTodoForm()
    {
        InitializeComponent();

        AdjustToCreateForm();

        ShowFieldsForSelectedTodoType();
    }

    // Adjust form components to make editing possible
    private void AdjustToEditForm(TodoType todoType)
    {
        Text = "Edytuj zadanie";
        TitleLabel.Text = "Edytuj zadanie";

        FormType = FormType.EDIT;

        TodoTypeCombobox.SelectedIndex = (int)todoType;
        TodoTypeCombobox.Enabled = false;

        ActionButton.Text = "Edytuj";

        DeleteButton.Visible = true;
    }

    private void AdjustToCreateForm()
    {
        FormType = FormType.CREATE;

        Text = "Stwórz zadanie";
        TitleLabel.Text = "Stwórz zadanie";
        ActionButton.Text = "Stwórz";

        TodoTypeCombobox.SelectedIndex = (int)TodoType.SHOPPING;
    }

    // Fill fields for both edit and create
    private void FillCommonFields(Todo todo)
    {
        TodoTitleTextbox.Text = todo.Title;
        TodoCompletedRadio.Checked = todo.Completed;
    }

    // Takes a todo and fills form components with saved values in database
    private void FillEditedTodo(string todoId)
    {
        switch (GetSelectedTodoType())
        {
            case TodoType.SHOPPING:
                var shoppingTodo = TodoShopping.GetFromDb(todoId)!;
                FillCommonFields(shoppingTodo);
                AdditionalTextbox.Text = shoppingTodo.ProductName;
                PriceNumeric.Value = (decimal)shoppingTodo.ProductPrice;
                break;
            case TodoType.WORK:
                var workTodo = TodoWork.GetFromDb(todoId)!;
                FillCommonFields(workTodo);
                AdditionalTextbox.Text = workTodo.Company;
                break;
            case TodoType.SCHOOL:
                var schoolTodo = TodoSchool.GetFromDb(todoId)!;
                FillCommonFields(schoolTodo);
                AdditionalTextbox.Text = schoolTodo.Subject;
                break;
            default:
                MessageBox.Show("Nieznany rodzaj zadania. Spróbuj ponownie");
                break;
        }
    }

    private void TodoTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
        ShowFieldsForSelectedTodoType();
    }

    private void ActionButton_Click(object sender, EventArgs e)
    {
        if (FormType == FormType.CREATE)
        {
            try
            {
                CreateTodo();
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                MessageBox.Show("Nieoczekiwany błąd. Nie udało się stworzyć zadania, sprawdź poprawność danych i spróbuj ponownie");

            }
        }
        else if (FormType == FormType.EDIT)
        {
            try
            {
                if (OnSubmitFunction is null)
                {
                    throw new Exception("OnSubmitFunction cannot be null when editing form");
                }

                EditTodo();
                OnSubmitFunction();
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                MessageBox.Show("Nieoczekiwany błąd. Edycja zadania się nie powiodła, spróbuj jeszcze raz");
            }
        }
        else
        {
            MessageBox.Show("Nieoczekiwany błąd. Operacja nie powiodła się, spróbuj jeszcze raz");
        }
    }

    // Takes values that user passed and update existing todo with given `TodoId`
    private void EditTodo()
    {
        var title = TodoTitleTextbox.Text;
        var completed = TodoCompletedRadio.Checked;

        if (TodoId is null)
        {
            throw new Exception("TodoId Cannot be null when editing todo");
        }

        switch (GetSelectedTodoType())
        {
            case TodoType.SHOPPING:
                var shoppingTodo = TodoShopping.GetFromDb(TodoId)!;
                shoppingTodo.Title = title;
                shoppingTodo.Completed = completed;
                shoppingTodo.ProductName = AdditionalTextbox.Text;
                shoppingTodo.ProductPrice = (float)PriceNumeric.Value;
                shoppingTodo.UpdateInDb();
                break;
            case TodoType.SCHOOL:
                var schoolTodo = TodoSchool.GetFromDb(TodoId)!;
                schoolTodo.Title = title;
                schoolTodo.Completed = completed;
                schoolTodo.Subject = AdditionalTextbox.Text;
                schoolTodo.UpdateInDb();
                break;
            case TodoType.WORK:
                var workTodo = TodoWork.GetFromDb(TodoId)!;
                workTodo.Title = title;
                workTodo.Completed = completed;
                workTodo.Company = AdditionalTextbox.Text;
                workTodo.UpdateInDb();
                break;
            default:
                MessageBox.Show("Nieznany rodzaj zadania. Spróbuj ponownie");
                break;
        }
    }

    // Create new todo in database
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
    }

    private static void ShowCreatedTodoInfo(string info)
    {
        MessageBox.Show($"Stworzono zadanie\n\n{info}");
    }

    // Shows different components according to selected TodoType
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

    // Delete Todo from DB
    private void DeleteTodo()
    {
        if (TodoId is null)
        {
            throw new Exception("TodoId Cannot be null when editing todo");
        }

        switch (GetSelectedTodoType())
        {
            case TodoType.SHOPPING:
                TodoShopping.DeleteFromDb(TodoId);
                break;
            case TodoType.WORK:
                TodoWork.DeleteFromDb(TodoId);
                break;
            case TodoType.SCHOOL:
                TodoSchool.DeleteFromDb(TodoId);
                break;
            default:
                throw new Exception("Unknown TodoType");
        }
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        if (OnSubmitFunction is null)
        {
            throw new Exception("OnSubmitFunction cannot be null when editing form");
        }

        var result = MessageBox.Show("Czy jesteś pewny, że chcesz usunąć?", "Potwierdź", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            DeleteTodo();
            OnSubmitFunction();
            Close();
        }
    }
}
