using Redspace.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpace.DAL
{
    public class UsuarioJogoDAL : Conexao
    {
        //CREATE | 
        public void CadastrarUsuarioJogo(UsuarioJogoDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO UsuarioJogo (IdUsuario, IdJogo, DataDownload) VALUES (@IdUsuario, @IdJogo, @DataDownload)", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", objCad.IdUsuario);
                cmd.Parameters.AddWithValue("@IdJogo", objCad.IdJogo);
                cmd.Parameters.AddWithValue("@DataDownload", objCad.DataDownload);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


        //READ | 
        public List<UsuarioJogoDTO> ListarUsuarioJogo(int id)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdUsuario, IdJogo, DataDownload, Status FROM (SELECT IdUsuario, IdJogo, DataDownload, Status, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS rn FROM UsuarioJogo WHERE IdUsuario = @IdUsuario AND Status = 1) AS subquery WHERE rn > (SELECT COUNT(*) - 6 FROM UsuarioJogo WHERE IdUsuario = @IdUsuario AND Status = 1);", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", id);
                dr = cmd.ExecuteReader();
                List<UsuarioJogoDTO> lista = new List<UsuarioJogoDTO>();
                while (dr.Read())
                {
                    UsuarioJogoDTO obj = new UsuarioJogoDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.DataDownload = Convert.ToDateTime(dr["DataDownload"]);
                    obj.Status = Convert.ToBoolean(dr["Status"]);
                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        // Verifica se o jogo já está no histórico
        public bool VerificaUsuarioJogo(int IdUsuario, int IdJogo)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM UsuarioJogo WHERE IdUsuario = @IdUsuario AND IdJogo = @IdJogo", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                cmd.Parameters.AddWithValue("@IdJogo", IdJogo);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //DELETE | Deletar (mudar status) do que foi selecionado
        public void ExcluirUsuarioJogo(int IdJogo, int IdUsuario)
        {
            try
            {
                Conectar();
                if (IdUsuario == 0)
                {
                    cmd = new SqlCommand("UPDATE UsuarioJogo SET Status = 0 WHERE IdJogo = @IdJogo", conn);
                    cmd.Parameters.AddWithValue("@IdJogo", IdJogo);
                }
                else
                {
                    cmd = new SqlCommand("UPDATE UsuarioJogo SET Status = 0 WHERE IdUsuario = @IdUsuario", conn);
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
