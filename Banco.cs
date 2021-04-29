using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;          // importei esses dois, data 
using System.Data.SQLite;  // importe data sqlite 
using System.Windows.Forms;

namespace CFB_Academia
{
    class Banco
    {
        //método da conexão
        //utilizando static, pois vou usar a qualquer lugar do meu programa 
        
        //variavel de conexão 
        private  static SQLiteConnection conexao;

   

        //Função para conexão

        private static SQLiteConnection ConexaoBanco()
        {
            //passando o caminho do meu banco de dados 
            //colocando duas barras pois é caractere de escape
            conexao = new SQLiteConnection("Data Source=C:\\Users\\lucas\\Documents\\CFB_Academia\\CFB_Academia\\Banco\\banco_academia.db");
            conexao.Open();

            
            return conexao;
        }

        public static DataTable ObterTodosUsuarios() // DataTable retorna conjunto de Dados do nosso Banco
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

             
            try
            {
                //recebendo a conexão e uma criação de comando de códido SQL
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //passando o cmd sql para todos os usuários
                    cmd.CommandText = "SELECT * FROM tb_usuarios";

                    // recebe o compando e a conexão, ele pega os dados do banco
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    //o datatable recebe o comando
                    //"dt" está preenchido com o conteúdo que foi passado (Fill) pelo nosso "da" 
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch(Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }


        //Método para genérico para consulta 
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();


            try
            {
                //recebendo a conexão e uma criação de comando de códido SQL
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //passando o cmd sql para todos os usuários
                    cmd.CommandText = sql;

                    // recebe o compando e a conexão, ele pega os dados do banco
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    //o datatable recebe o comando
                    //"dt" está preenchido com o conteúdo que foi passado (Fill) pelo nosso "da" 
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
                
            }

        }

        //Funções do Form F_NovoUsuario

        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u) == true)
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SEHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                    //associando o value ao objeto
                cmd.Parameters.AddWithValue("@nome", u.NomeUsuario);
                cmd.Parameters.AddWithValue("@username", u.Username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido");
                ConexaoBanco().Close();
            
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao cadastrar usuário {0}",e.Message);
                ConexaoBanco().Clone();
            }


        }


        //Fim da Funções do Form F_NovoUsuario

        //ROTINAS GERAIS 

        public static bool existeUsername(Usuario u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME = '"+u.Username+"' "; //QUERY QUE VAI BUSCAR O USERNAME 
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }

    }
}

