using TodoList.Models;

namespace TodoList;

class TodoShopping : Todo, ITodoMethods<TodoShopping>
{
    static readonly string TableName = "TodosShopping";

    public string ProductName;
    public float ProductPrice;

    private TodoShopping(
        string id, 
        string title, 
        bool completed, 
        string productName, 
        float productPrice
    ) : base(id, title, completed)
    {
        ProductPrice = productPrice;
        ProductName = productName;
    }

    public TodoShopping(
        string title, 
        bool completed, 
        string productName, 
        float productPrice
    ) : base(
        title,
        completed,
        TableName,
        new[] { "ProductName TEXT NOT NULL", "ProductPrice REAL NOT NULL" },
        new Dictionary<string, object> {
            { "ProductName", productName },
            { "ProductPrice", productPrice },
        }
    )
    {
        ProductName = productName;
        ProductPrice = productPrice;
    }

    public new string GetInfo()
    {
        return $"{base.GetInfo()}\nNazwa produktu: {ProductName}\nCena produktu: {ProductPrice}PLN";
    }

    public void UpdateInDb()
    {
        UpdateInDb(TableName, new Dictionary<string, object> { 
            { "ProductName", ProductName },
            { "ProductPrice", ProductPrice }
        });
    }

    static public TodoShopping? GetFromDb(string id)
    {
        var todo = GetFromDb<TodoShoppingModel>(id, TableName);

        if (todo is null) return null;

        return new TodoShopping(
            todo.Id,
            todo.Title,
            todo.Completed,
            todo.ProductName, 
            todo.ProductPrice
        );
    }
    static public void DeleteFromDb(string id)
    {
        DeleteFromDb(TableName, id);
    }

    static public List<TodoShopping> GetAllFromDb()
    {
        return GetAllFromDb<TodoShoppingModel>(TableName)
            .Select((todo) => new TodoShopping(
                todo.Id,
                todo.Title,
                todo.Completed,
                todo.ProductName,
                todo.ProductPrice
            ))
            .ToList();
    }
}
