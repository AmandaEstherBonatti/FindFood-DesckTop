using System;

namespace Database
{
    interface ICategoria
    {
        void SetInformacoes(int Id, string nome);

        void Gravar();
    }
}
