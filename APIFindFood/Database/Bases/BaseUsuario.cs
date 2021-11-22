using Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Database.Bases
{
    public abstract class BaseUsuario : IUsuario
    {
        public BaseUsuario(string email, string senha, string nome)
        {
            this.Email = email;
            this.Senha = senha;
            this.Nome = nome;
        }
        public BaseUsuario() { }

        public string Email;
        public string Senha;
        public string Nome;

        public void SetInformacoes(string email, string senha, string nome)
        {
            this.Email = email;
            this.Senha = senha;
            this.Nome = nome;

        }

        public void GetInformacoes(string email, string senha)
        {
            string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"select Email, Senha from Usuarios where Email='{email}' and Senha='{senha}';";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void SalvarInformacoes()
        {
            string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"insert into Usuarios(Email, Senha, Nome)values( '{this.Email}', '{this.Senha}', '{this.Nome}');";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AtualizarInformaçoes(string email)
        {
            throw new NotImplementedException();
        }

        public void DeletarInformações(string email)
        {
            throw new NotImplementedException();
        }
    }
}
