using MySqlConnector;

public class SQLInjection
{
    private readonly MySqlConnection connection;

    public SQLInjection(MySqlConnection connection)
    {
        this.connection = connection;
    }

    public async Task Vulnerability(string id)
    {
        using MySqlCommand command = new MySqlCommand("SELECT * FROM accounts WHERE custID='" + id + "'", connection);
        using MySqlDataReader reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            // ....
        }
    }
}