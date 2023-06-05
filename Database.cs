using Microsoft.Data.Sqlite;

namespace TodoList;

static class Database
{
    static readonly string ConnectionString = "Data Source=TodoList.db";

    public static Result Action<Result>(Func<SqliteConnection, Result> function)
    {
        var connection = new SqliteConnection(ConnectionString);
        
        Result result = function(connection);

        connection.Close();

        return result;
    }
}
