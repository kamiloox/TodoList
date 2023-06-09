using TodoList.Models;

namespace TodoList;

class TodoSchool : Todo, ITodoMethods<TodoSchool>
{
    static readonly string TableName = "TodosSchool";

    /**
     * E.g. Math, Physics, English
     */
    public string Subject;

    private TodoSchool(
        string id, 
        string title, 
        bool completed, 
        string subject
    ) : base(id, title, completed)
    {
        Subject = subject;
    }

    public TodoSchool(
        string title,
        bool completed,
        string subject
    ) : base(
        title,
        completed,
        TableName,
        new[] { "Subject TEXT NOT NULL" },
        new Dictionary<string, object> {
            { "Subject", subject },
        }
    ) 
    {   
        Subject = subject;
    }

    public new string GetInfo() => $"{base.GetInfo()}\nPrzedmiot: {Subject}";

    public void UpdateInDb()
    {
        UpdateInDb(TableName, new Dictionary<string, object> {
            { "Subject", Subject },
        });
    }

    static public TodoSchool? GetFromDb(string id)
    {
        var todo = GetFromDb<TodoSchoolModel>(id, TableName);

        if (todo is null) return null;

        return new TodoSchool(
            todo.Id, 
            todo.Title, 
            todo.Completed, 
            todo.Subject
        );
    }

    static public void DeleteFromDb(string id)
    {
        DeleteFromDb(TableName, id);
    }

    static public List<TodoSchool> GetAllFromDb()
    {
        return GetAllFromDb<TodoSchoolModel>(TableName)
            .Select((todo) => new TodoSchool(
                todo.Id,
                todo.Title,
                todo.Completed,
                todo.Subject
            ))
            .ToList();
    }
}
