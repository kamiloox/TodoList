using TodoList.Models;

namespace TodoList;

class TodoWork : Todo, ITodoMethods<TodoWork>
{
    static readonly string TableName = "TodosWork";

    /*
     * Company for which Todo needs to be done
     */
    public string Company;

    private TodoWork(
        string id, 
        string title, 
        bool completed, 
        string company
    ) : base(id, title, completed)
    {
        Company = company;
    }

    public TodoWork(
        string title,
        bool completed,
        string company
    ) 
    : base(
        title,
        completed,
        TableName,
        new[] { "Company TEXT NOT NULL" },
        new Dictionary<string, object> {
            { "Company", company }
        }
    )
    {
        Company = company;
    }

    public new string GetInfo() => $"{base.GetInfo()}\nFirma: {Company}";

    public void UpdateInDb()
    {
        UpdateInDb(TableName, new Dictionary<string, object> {
            { "Company", Company }
        });
    }

    static public TodoWork? GetFromDb(string id)
    {
        var todo = GetFromDb<TodoWorkModel>(id, TableName);

        if (todo is null) return null;

        return new TodoWork(
            todo.Id,
            todo.Title,
            todo.Completed,
            todo.Company
        );
    }

    static public void DeleteFromDb(string id)
    {
        DeleteFromDb(TableName, id);
    }

    static public List<TodoWork> GetAllFromDb()
    {
        return GetAllFromDb<TodoWorkModel>(TableName)
            .Select((todo) => new TodoWork(
                todo.Id, 
                todo.Title, 
                todo.Completed, 
                todo.Company
            ))
            .ToList();
    }
}
