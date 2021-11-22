using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    interface IPrato
    {
        void SetInformacoes(int id, string nome, BaseCategoria categoria);
        void GetInformacoes(int id, string nome, BaseCategoria categoria);
        void SalvarInformacoes();
        void AtualizarInformaçoes(int Id);
        void DeletarInformações(int Id);
    }
}
