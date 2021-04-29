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
    public partial class Central : Form
    {
        public Central()
        {
            InitializeComponent();
            //chamando o formulário de Login 
            F_login f_login = new F_login(this);
            f_login.ShowDialog();

            Restricao();


        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
            Restricao();
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
            
            RestricaoLogoff();
        }
       
        //RESTRIÇÃO
        private void  Restricao()
        {

           switch (Globais.nivel)
            {
                case 1:
                    m_usuarios.Visible = true;
                    m_manun.Visible = false;
                    m_login.Visible = true;
                    m_aluno.Visible = true;
                break;
                case 2:
                    m_usuarios.Visible = true;
                    m_manun.Visible = true;
                    m_login.Visible = true;
                    m_aluno.Visible = true;
                break;
                case 3:
                    m_usuarios.Visible = true;
                    m_manun.Visible = true;
                    m_login.Visible = true;
                    m_aluno.Visible = true;
                break;
                default:
                    MessageBox.Show("Nivel inválido");
                    break;      
            }
        }
        //RESTRIÇÃO LOGOFF
        private void RestricaoLogoff()
        {

        if (Globais.logado == false)
            {
                m_usuarios.Visible = false;
                m_manun.Visible = false;
                m_login.Visible = true;
                m_aluno.Visible = false;
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globais.logado == true)
            {
                if(Globais.nivel >= 2)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
            }

        }
    }
}
