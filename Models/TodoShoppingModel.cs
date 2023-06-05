namespace TodoList.Models;

class TodoShoppingModel : TodoModel
{
    public string ProductName { get; set; } = string.Empty;
    public float ProductPrice { get; set; } = 0;
}
