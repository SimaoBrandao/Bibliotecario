using System.Configuration;

namespace CamadaDados
{
    public class DatabaseConnection
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        }
    }
}
