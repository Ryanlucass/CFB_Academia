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
    }
}
