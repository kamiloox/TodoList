namespace TodoList;

interface ITodoMethods<TodoType>
{
    void UpdateInDb();

    string GetInfo();

    static public List<TodoType> GetAllFromDb() => throw new NotImplementedException();

    static public TodoType? GetFromDb(string id) => throw new NotImplementedException();

    static public void RemoveFromDb(string id) => throw new NotImplementedException();
}
