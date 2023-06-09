namespace TodoList.Models;


/*
 * Model is a representation only in database
 * It defines fields that will be saved, Models are needed by Dapper library
 * It cannot be done only with Todo and its derived classes.
 */
class TodoModel
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public bool Completed { get; set; } = false;
}
