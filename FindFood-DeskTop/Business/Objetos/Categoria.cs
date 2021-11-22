using System;
using Database;

namespace Business
{
    public class Categoria : BaseCategoria
    {
        public Categoria(int id,string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        public Categoria() { } 

    }
}
