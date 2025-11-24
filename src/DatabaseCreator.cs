using Microsoft.Data.Sqlite;



public static class DatabaseCreator
{
    public static void CreateDatabase()
    {
        string connectionString = "Data Source=familytree.db";

        // SQL lesen
        string sql = File.ReadAllText("Database/create.sql");

        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = sql;
        command.ExecuteNonQuery();
    }
}
