using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Interfaces
{
    interface IUsuario
    {
        void SetInformacoes(string email, string senha, string nome);
        void GetInformacoes(string email, string senha, string nome);
        void SalvarInformacoes();
        void AtualizarInformaçoes(string email);
        void DeletarInformações(string email);
    }
}
