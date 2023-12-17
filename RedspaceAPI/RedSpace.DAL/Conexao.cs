using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpace.DAL
{
    public class Conexao
    {
        protected SqlCommand cmd;       // Pega os comandos e os executa
        protected SqlDataReader dr;     // Lê os dados
        protected SqlConnection conn;   // Leva a chave/string de conexão

        protected void Conectar()
        {
            try
            {
                conn = new SqlConnection(@"there-is-no-connection-string-here-hahahaha");
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        protected void Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
