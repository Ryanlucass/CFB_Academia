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


    }
}
