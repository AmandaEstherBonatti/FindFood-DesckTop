using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Usuario
    {
        private string connectionString;
        public Usuario() => connectionString = ConfigurationManager.AppSettings["SqlConnection"];

        public void Gravar(string email, string nome, string senha)
        {
            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                string queryString = $"insert into Usuarios (Email, Nome, Senha)values('{email}', '{nome}', '{senha}');";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
