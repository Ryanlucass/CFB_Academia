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

        }

        //botão Cancelar 
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
