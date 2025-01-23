using System.Configuration;
using System.Text.RegularExpressions;

namespace Bibliotecario
{
    public class DatabaseConnection
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        

        public void SalvarDatabaseConnection(string Server, string Port, string User, string Password)
        {
            string connectionString = $"Server={Server};Database=Bibliotecario;Port={Port};User Id={User};Password={Password};";

            // Atualize a string de conexão no arquivo de configuração
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["MyDbConnection"].ConnectionString = connectionString;
            config.Save(ConfigurationSaveMode.Modified);

            // Força o recarregamento da configuração
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        // Método para extrair o valor de uma chave na string de conexão
        private string ExtrairValorDatabaseConnection(string connectionString, string chave)
        {
            // Expressão regular para encontrar a chave e o valor
            string pattern = $@"{chave}=(.*?)(?=(;|$))";
            Match match = Regex.Match(connectionString, pattern);

            return match.Success ? match.Groups[1].Value : null;
        }

        public DatabaseConnection ObterDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.Server = ExtrairValorDatabaseConnection(connectionString, "Server");
            databaseConnection.Port = ExtrairValorDatabaseConnection(connectionString, "Port");
            databaseConnection.Database = ExtrairValorDatabaseConnection(connectionString, "Database");
            databaseConnection.User = ExtrairValorDatabaseConnection(connectionString, "User Id");
            databaseConnection.Password = ExtrairValorDatabaseConnection(connectionString, "Password");
            return databaseConnection;
        }
    }
}
