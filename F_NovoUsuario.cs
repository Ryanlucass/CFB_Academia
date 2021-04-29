using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.NomeUsuario = tbNome.Text;
            usuario.Username = tbUsername.Text;
            usuario.senha = tbSenha.Text;
            usuario.status = cbStatus.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(npNivel.Value, 0)); //indo na biblioteca de math. 0 significa nenhuma casa decimal 


            Banco.NovoUsuario(usuario);


        }

        //BOTÃO CANCELAR 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbUsername.Clear();
            tbSenha.Clear();
            cbStatus.Text = "";
            npNivel.Value = 0;
            tbNome.Focus();
        }
    }
}
