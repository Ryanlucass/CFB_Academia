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
        private static SQLiteConnection conexao;


        //Função para conexão

        private static SQLiteConnection ConexaoBanco()
        {
            //passando o caminho do meu banco de dados 
            //colocando duas barras pois é caractere de escape
            conexao = new SQLiteConnection("Data Source=C:\\Users\\lucas\\Documents\\CFB_Academia\\CFB_Academia\\Banco\\banco_academia.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
