using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Business.Objetos;
namespace FindFood.UI
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltarPag_Click(object sender, EventArgs e)
        {
            FecharPagina();
        }

        private void bntSalvarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nome = txtNome.Text;
            usuario.SalvarInformacoes();
            FecharPagina();


        }
        private void FecharPagina()
        {
            var home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
