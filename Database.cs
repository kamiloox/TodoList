using Microsoft.Data.Sqlite;

namespace TodoList;

static class Database
{
    static readonly string ConnectionString = "Data Source=TodoList.db";

    /*
     * Sets a database connection, run a desired action and close connection
     */
    public static Result Action<Result>(Func<SqliteConnection, Result> function)
    {
        var connection = new SqliteConnection(ConnectionString);
        
        Result result = function(connection);

        connection.Close();

        return result;
    }
}
