using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace sys_IATI
{
    public class dbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; private set; }

        // Construtor que inicializa a conexão
        public dbConnection()
        {
            // String de conexão 
            string connectionString = "Server=localhost;Port=5432;Database=IATI;User Id=postgres;Password=270805";
            Connection = new NpgsqlConnection(connectionString);

            try
            {
                Connection.Open(); // Abre a conexão
                Console.WriteLine("Conexão com o banco de dados aberta com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                throw; // Re-lança a exceção para que o chamador saiba que houve um erro
            }
        }

        // Método para fechar a conexão explicitamente
        public void Close()
        {
            if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
                Console.WriteLine("Conexão com o banco de dados fechada.");
            }
        }

        // Implementação do IDisposable para liberar recursos
        public void Dispose()
        {
            Close();
            Connection?.Dispose(); // Libera os recursos da conexão
        }
    }
}

