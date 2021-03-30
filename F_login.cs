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
    public partial class F_login : Form
    {
        
        Form1 form1;

        DataTable dt = new DataTable();

        public F_login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        // botão Acessar 
        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (username == "")
            {
                MessageBox.Show("Username Inválido");
                return;
            }
            else if (password == "") 
            {
                MessageBox.Show("Password Inválido");
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='"+username+ "' AND T_SEHAUSUARIO='" + password+"'";
            dt = Banco.consulta(sql);
            
            //verificando se o valor encontrados de linha é somente um 
            
            if(dt.Rows.Count == 1)
            {
                //converter para string, já que estou passando para um label e é um integer 
                //Mudando Acesso
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                //Mudando Nome de Usuário
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                //Mudando Imagem
                form1.pb_ledlogado.Image = Properties.Resources.led_verde;

                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        //botão Cancelar 
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
