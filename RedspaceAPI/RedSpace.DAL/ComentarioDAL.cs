using Redspace.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RedSpace.DAL
{
    public class ComentarioDAL : Conexao
    {
        //CREATE | Cadastro de Comentario
        public void CadastrarComentario(ComentarioDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Comentario (IdUsuario, IdJogo, Nota, Comentario, Data) VALUES (@IdUsuario, @IdJogo, @Nota, @Comentario, @Data);", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", objCad.IdUsuario);
                cmd.Parameters.AddWithValue("@IdJogo", objCad.IdJogo);
                cmd.Parameters.AddWithValue("@Nota", objCad.Nota);
                cmd.Parameters.AddWithValue("@Comentario", objCad.Comentario);
                cmd.Parameters.AddWithValue("@Data", objCad.Data);
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

        //READ | Listar Comentarios
        public List<ComentarioDTO> ListarComentarios(int idJogo)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT C.IdComentario, C.IdJogo, C.Nota, U.Nome, C.Comentario, C.Data, C.Status FROM Comentario AS C INNER JOIN Usuario AS U ON U.IdUsuario = C.IdUsuario WHERE C.IdJogo = @IdJogo;", conn);
                cmd.Parameters.AddWithValue("@IdJogo", idJogo);
                dr = cmd.ExecuteReader();
                List<ComentarioDTO> lista = new List<ComentarioDTO>();
                while (dr.Read())
                {
                    ComentarioDTO obj = new ComentarioDTO();
                    obj.IdComentario = Convert.ToInt32(dr["IdComentario"]);
                    obj.IdJogo = dr["IdJogo"].ToString();
                    obj.Nota = Convert.ToInt32(dr["Nota"]);
                    obj.IdUsuario = dr["Nome"].ToString();
                    obj.Comentario = dr["Comentario"].ToString();
                    obj.Data = Convert.ToDateTime(dr["Data"]);
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

        //UPDATE | Editar ou atualizar um Comentario já existente
        public void EditarComentario(ComentarioDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Comentario SET Comentario = @Comentario, Nota = @Nota WHERE IdComentario = @IdComentario;", conn);
                cmd.Parameters.AddWithValue("@IdComentario", objEdita.IdComentario);
                cmd.Parameters.AddWithValue("@Comentario", objEdita.Comentario);
                cmd.Parameters.AddWithValue("@Nota", objEdita.Nota);
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

        //DELETE | Deletar (mudar status) do que foi selecionado
        public void ExcluirComentario(int objDel)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Comentario SET Status = 0 WHERE IdComentario = @IdComentario;", conn);
                cmd.Parameters.AddWithValue("@IdComentario", objDel);
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