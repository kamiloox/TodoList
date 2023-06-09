namespace TodoList;

// Defines methods that needs to be implemented on derived classes
// It forces programmer to implement these methods so that every TodoType will be consistent
interface ITodoMethods<TodoType>
{
    void UpdateInDb();

    string GetInfo();

    static public List<TodoType> GetAllFromDb() => throw new NotImplementedException();

    static public TodoType? GetFromDb(string id) => throw new NotImplementedException();

    static public void RemoveFromDb(string id) => throw new NotImplementedException();
}
