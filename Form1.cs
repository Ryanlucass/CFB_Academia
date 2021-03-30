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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //chamando o formulário de Login 
            F_login f_login = new F_login(this);
            f_login.ShowDialog();

           
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //converter para string, já que estou passando para um label e é um integer 
            //Mudando Acesso
            lb_acesso.Text = "Null";
            //Mudando Nome de Usuário
            lb_nomeUsuario.Text = "...";
            //Mudando Imagem
            pb_ledlogado.Image = Properties.Resources.led_vermelho;

            Globais.nivel = 0;
            Globais.logado = false;
        }
    }
}
