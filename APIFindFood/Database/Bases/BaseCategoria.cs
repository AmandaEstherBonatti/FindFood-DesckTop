using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public abstract class BaseCategoria : ICategoria
    {
        public BaseCategoria(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        public BaseCategoria() { }

        public int Id;
        public string Nome;

        public void SetInformacoes(int id, string nome) { this.Id = id;  this.Nome = nome; }

        public virtual void Gravar()
        {
            string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
            using SqlConnection connection = new SqlConnection(connectionString);
            string queryString = $"insert into Categorias(PKCategoria, Nome)values( '{this.Id}','{this.Nome}');";
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();

        }

    }
}
