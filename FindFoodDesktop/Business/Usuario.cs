

namespace Business
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public void Gravar()
        {
            new Database.Usuario().Gravar(this.Email, this.Nome, this.Senha);
        }

    }
}