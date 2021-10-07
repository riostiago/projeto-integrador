using MySql.Data.MySqlClient;
namespace pagina_inicio
{
    public class Conexao
    {
        MySqlConnection conecte = new MySqlConnection();
        public Conexao()
        {
            conecte.ConnectionString = "server = localhost; user id = root; Database = lojahow3; SslMode = none"; // string de conexão com o banco
        }
        public MySqlConnection Conectar()
        {
            if (conecte.State == System.Data.ConnectionState.Closed) // se status de conexão for off ele abre
            {
                conecte.Open();
            }
            return conecte;
        }
        public MySqlConnection Desconectar()
        {
            if (conecte.State == System.Data.ConnectionState.Open) // se status de conexão for on ele fecha
            {
                conecte.Close();
            }
            return conecte;
        }
    }
}