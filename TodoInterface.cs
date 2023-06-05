namespace TodoList;

interface ITodoMethods<T>
{
    void UpdateInDb();

    public string GetInfo();

    static public List<T> GetAllFromDb() => throw new NotImplementedException();

    static public T? GetFromDb(string id) => throw new NotImplementedException();
}
