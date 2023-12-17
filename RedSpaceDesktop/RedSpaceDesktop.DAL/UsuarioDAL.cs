using RedSpaceDesktop.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpaceDesktop.DAL
{
    public class UsuarioDAL : Conexao
    {
        // Cadastrando usuário
        public void CadastrarUsuario(UsuarioDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Usuario (Nome, Senha, Email) VALUES (@Nome, @Senha, @Email)", conn);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@Email", objCad.Email);
                cmd.Parameters.AddWithValue("@Senha", objCad.Senha);
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

        // Read
        public List<UsuarioDTO> ListarUsuarios()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdUsuario, Nome, Senha, Email, Status FROM Usuario;", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> lista = new List<UsuarioDTO>();
                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
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

        // Update
        public void EditarUsuario(UsuarioDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Usuario SET Nome = @Nome, Senha = @Senha, Email = @Email WHERE IdUsuario = @IdUsuario", conn);
                cmd.Parameters.AddWithValue("@Nome", objEdita.Nome);
                cmd.Parameters.AddWithValue("@Email", objEdita.Email);
                cmd.Parameters.AddWithValue("@Senha", objEdita.Senha);
                cmd.Parameters.AddWithValue("@IdUsuario", objEdita.IdUsuario);
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

        // Delete
        public void ExcluirUsuario(int IdUsuario)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Usuario SET Status = 0 WHERE IdUsuario = @IdUsuario", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
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

        // Buscando por ID
        public UsuarioDTO BuscaUsuarioPorId(int objIdUsuario)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE IdUsuario = @IdUsuario", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", objIdUsuario);
                dr = cmd.ExecuteReader();
                UsuarioDTO obj = new UsuarioDTO();
                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.Status = Convert.ToBoolean(dr["Status"]);
                }
                return obj;
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        //AUTENTICAÇÃO
        public UsuarioDTO Autenticar(string nome, string senha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE Nome = @nome AND Senha = @senha;", conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                dr = cmd.ExecuteReader();
                UsuarioDTO obj = null;//ponteiro
                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.Nome = dr["Nome"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.Email = dr["Email"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception($"Usuário não cadastrado ou inexistente! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
