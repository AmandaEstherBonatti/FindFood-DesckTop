using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Database.Bases
{
    public abstract class BasePrato : IPrato
    {
        public BasePrato(int id, string nome, BaseCategoria categoria)
        {
            this.Id = id;
            this.Nome = nome;
            this.Categoria = categoria;
        }
        public BasePrato() { }

        public int Id;
        public string Nome;
        public BaseCategoria Categoria;

        public void SetInformacoes(int id, string nome, BaseCategoria categoria) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Categoria = categoria;

        }

        public void GetInformacoes(int id, string nome, BaseCategoria categoria)
        {
            throw new NotImplementedException();
        }

        public void SalvarInformacoes()
        {
            string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"insert into{this.GetType().Name}(nome, categoria)values( '{this.Nome}', '{this.Categoria}');";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AtualizarInformaçoes(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeletarInformações(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
