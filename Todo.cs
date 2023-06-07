using Dapper;

namespace TodoList;

class Todo
{
    public string Id;
    public string Title;
    public bool Completed;


    /**
     * When id is not given in constructor then new object is created in database 
     */
    protected Todo(string title, bool completed, string tableName, string[] tableProperties, Dictionary<string, object> fields)
    {
        Id = Guid.NewGuid().ToString();
        Title = title;
        Completed = completed;

        CreateTableIfNotExists(tableName, tableProperties);
        CreateInDb(tableName, fields);
    }

    /**
      * Initialize fields without creating a new object in database
      */
    protected Todo(string id, string title, bool completed)
    {
        Id = id;
        Title = title;
        Completed = completed;
    }

    public string GetInfo()
    {
        string completedText = Completed ? "Tak" : "Nie";

        return $"Id: {Id}\nTytuł: {Title}\nUkończono: {completedText}";
    }

    private static void CreateTableIfNotExists(string tableName, string[] fields)
    {
        string[] commonFields =
        {
            "Id TEXT PRIMARY KEY",
            "Title TEXT NOT NULL",
            "Completed BOOLEAN NOT NULL",
        };

        var joinedFields = string.Join(',', commonFields.Concat(fields).ToArray());

        string query = $"CREATE TABLE IF NOT EXISTS {tableName}({joinedFields})";

        Database.Action((connection) => connection.Execute(query));
    }

    private void CreateInDb(string tableName, Dictionary<string, object> fields)
    {
        Dictionary<string, object> allFields = new()
        {
            { "Id", Id },
            { "Title", Title },
            { "Completed", Completed },
        };

        fields.ToList().ForEach(field => allFields.Add(field.Key, field.Value));

        var keys = string.Join(", ", allFields.Keys);
        var values = string.Join(", ", allFields.Keys.Select((key) => $"@{key}"));

        var query = $@"
            INSERT INTO {tableName}({keys}) 
            VALUES({values})
        ";

        Database.Action((connection) => connection.Execute(query, allFields));
    }

    protected void UpdateInDb(string tableName, Dictionary<string, object> fields)
    {
        Dictionary<string, object> allFields = new()
        {
            { "Id", Id },
            { "Title", Title },
            { "Completed", Completed },
        };

        fields.ToList().ForEach(field => allFields.Add(field.Key, field.Value));

        List<string> parsed = new();

        foreach (var field in allFields)
        {
            parsed.Add($"{field.Key} = @{field.Key}");
        }

        var query = $@"
            UPDATE {tableName} SET 
            {string.Join(",", parsed)}
            WHERE Id = @Id
        ";

        Database.Action((connection) => connection.Execute(query, allFields));
    }

    static protected TodoModel? GetFromDb<TodoModel>(string id, string tableName)
    {
        var query = $"SELECT * FROM {tableName} WHERE Id = @id";

        var parameters = new { id, tableName };

        return Database.Action((connection) => connection.QueryFirstOrDefault<TodoModel>(query, parameters));
    }

    static protected List<TodoModel> GetAllFromDb<TodoModel>(string tableName)
    {
        var query = $"SELECT * FROM {tableName}";

        return Database.Action((connection) => connection.Query<TodoModel>(query).ToList());
    }

    static protected void DeleteFromDb(string tableName, string todoId)
    {
        var query = $"DELETE FROM {tableName} WHERE Id = @Id";

        var parameters = new { Id = todoId };

        Database.Action((connection) => connection.Query(query, parameters));
    }
}
