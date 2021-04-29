
namespace CFB_Academia
{
    partial class Central
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nomeUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_ledlogado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_novousuario = new System.Windows.Forms.ToolStripMenuItem();
            this.m_manun = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_bd = new System.Windows.Forms.ToolStripMenuItem();
            this.m_login = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_logon = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_logoff = new System.Windows.Forms.ToolStripMenuItem();
            this.m_aluno = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledlogado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lb_nomeUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_ledlogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 0;
            // 
            // lb_nomeUsuario
            // 
            this.lb_nomeUsuario.AutoSize = true;
            this.lb_nomeUsuario.Location = new System.Drawing.Point(193, 9);
            this.lb_nomeUsuario.Name = "lb_nomeUsuario";
            this.lb_nomeUsuario.Size = new System.Drawing.Size(20, 17);
            this.lb_nomeUsuario.TabIndex = 4;
            this.lb_nomeUsuario.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário:";
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(98, 9);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(32, 17);
            this.lb_acesso.TabIndex = 2;
            this.lb_acesso.Text = "Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso: ";
            // 
            // pb_ledlogado
            // 
            this.pb_ledlogado.Image = global::CFB_Academia.Properties.Resources.led_vermelho;
            this.pb_ledlogado.Location = new System.Drawing.Point(3, 3);
            this.pb_ledlogado.Name = "pb_ledlogado";
            this.pb_ledlogado.Size = new System.Drawing.Size(33, 29);
            this.pb_ledlogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledlogado.TabIndex = 0;
            this.pb_ledlogado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_usuarios,
            this.m_manun,
            this.m_login,
            this.m_aluno});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_usuarios
            // 
            this.m_usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_novousuario,
            this.novoUsuárioToolStripMenuItem});
            this.m_usuarios.Name = "m_usuarios";
            this.m_usuarios.Size = new System.Drawing.Size(83, 24);
            this.m_usuarios.Text = "Usuários ";
            // 
            // mn_novousuario
            // 
            this.mn_novousuario.Name = "mn_novousuario";
            this.mn_novousuario.Size = new System.Drawing.Size(224, 26);
            this.mn_novousuario.Text = "Gestão de Usuários";
            // 
            // m_manun
            // 
            this.m_manun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_bd});
            this.m_manun.Name = "m_manun";
            this.m_manun.Size = new System.Drawing.Size(113, 24);
            this.m_manun.Text = "Manuntenção";
            // 
            // mn_bd
            // 
            this.mn_bd.Name = "mn_bd";
            this.mn_bd.Size = new System.Drawing.Size(203, 26);
            this.mn_bd.Text = "Banco de dados ";
            // 
            // m_login
            // 
            this.m_login.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_logon,
            this.mn_logoff});
            this.m_login.Name = "m_login";
            this.m_login.Size = new System.Drawing.Size(60, 24);
            this.m_login.Text = "Login";
            // 
            // mn_logon
            // 
            this.mn_logon.Name = "mn_logon";
            this.mn_logon.Size = new System.Drawing.Size(136, 26);
            this.mn_logon.Text = "Logon";
            this.mn_logon.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // mn_logoff
            // 
            this.mn_logoff.Name = "mn_logoff";
            this.mn_logoff.Size = new System.Drawing.Size(136, 26);
            this.mn_logoff.Text = "Logoff";
            this.mn_logoff.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // m_aluno
            // 
            this.m_aluno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem});
            this.m_aluno.Name = "m_aluno";
            this.m_aluno.Size = new System.Drawing.Size(62, 24);
            this.m_aluno.Text = "Aluno";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário ";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Central";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFB Academia - v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledlogado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pb_ledlogado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_nomeUsuario;
        public System.Windows.Forms.Label lb_acesso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_login;
        private System.Windows.Forms.ToolStripMenuItem mn_logon;
        private System.Windows.Forms.ToolStripMenuItem mn_logoff;
        private System.Windows.Forms.ToolStripMenuItem m_usuarios;
        private System.Windows.Forms.ToolStripMenuItem mn_novousuario;
        private System.Windows.Forms.ToolStripMenuItem m_manun;
        private System.Windows.Forms.ToolStripMenuItem mn_bd;
        private System.Windows.Forms.ToolStripMenuItem m_aluno;
        private System.Windows.Forms.ToolStripMenuItem novoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
    }
}

