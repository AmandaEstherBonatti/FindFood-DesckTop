using Database.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Objetos
{
    public class Usuario : BaseUsuario
    {
        public Usuario(string email, string senha, string nome)
        {
            this.Email = email;
            this.Senha = senha;
            this.Nome = nome;
        }

        public Usuario() { }
    }
}
