using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;          // importei esses dois, data 
using System.Data.SQLite;  // importe data sqlite 

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
    }
}
