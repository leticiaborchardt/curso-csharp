using System.Data.SqlClient;
using System.Data.SQLite;

string caminhoDB = @"/var/www/html/estudos/C#/curso-csharp/Modulo6/Ap.Controle/Ap.Controle.Db.sqlite3";

// String de conexão do SQLite
string connectionString = $"Data Source={caminhoDB};Version=3;";

// Criação do arquivo do banco de dados e conexão
using (SQLiteConnection connection = new SQLiteConnection(connectionString))
{
    connection.Open();

    // Criação de uma tabela simples
    string createTableQuery = "CREATE TABLE IF NOT EXISTS MinhaTabela (Id INTEGER PRIMARY KEY, Nome TEXT);";

    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
    {
        command.ExecuteNonQuery();
    }

    Console.WriteLine($"Banco de dados e tabela criados com sucesso em: {caminhoDB}");
}