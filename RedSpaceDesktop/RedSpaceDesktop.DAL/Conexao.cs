using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpaceDesktop.DAL
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
                conn = new SqlConnection(@"get-out");
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RedSpaceDB;Integrated Security=True;
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
