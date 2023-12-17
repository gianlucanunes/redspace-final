using Redspace.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RedSpace.DAL
{
    public class DesenvolvedorDAL : Conexao
    {
        //CREATE | Cadastro de Desenvolvedor
        public void CadastrarDesenvolvedor(DesenvolvedorDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Desenvolvedor (Nome, Senha, Email, Instagram, Twitter, Discord) VALUES (@Nome, @Senha, @Email, @Instagram, @Twitter, @Discord);", conn);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@Senha", objCad.Senha);
                cmd.Parameters.AddWithValue("@Email", objCad.Email);
                cmd.Parameters.AddWithValue("@Instagram", objCad.Instagram);
                cmd.Parameters.AddWithValue("@Twitter", objCad.Twitter);
                cmd.Parameters.AddWithValue("@Discord", objCad.Discord);
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





        //READ | Listar Desenvolvedores(as)
        public List<DesenvolvedorDTO> ListarDesenvolvedores()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdDesenvolvedor, Nome, Senha, Email, Instagram, Twitter, Discord, Status FROM Desenvolvedor;", conn);
                dr = cmd.ExecuteReader();
                List<DesenvolvedorDTO> lista = new List<DesenvolvedorDTO>();
                while (dr.Read())
                {
                    DesenvolvedorDTO obj = new DesenvolvedorDTO();
                    obj.IdDesenvolvedor = Convert.ToInt32(dr["IdDesenvolvedor"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Instagram = dr["Instagram"].ToString();
                    obj.Twitter = dr["Twitter"].ToString();
                    obj.Discord = dr["Discord"].ToString();
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





        //UPDATE | Editar ou atualizar Desenvolvedor já existente
        public void EditarDesenvolvedor(DesenvolvedorDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Desenvolvedor SET Nome = @Nome, Senha = @Senha, Email = @Email, Instagram = @Instagram, Twitter = @Twitter, Discord = @Discord WHERE IdDesenvolvedor = @IdDesenvolvedor;", conn);
                cmd.Parameters.AddWithValue("@IdDesenvolvedor", objEdita.IdDesenvolvedor);
                cmd.Parameters.AddWithValue("@Nome", objEdita.Nome);
                cmd.Parameters.AddWithValue("@Senha", objEdita.Senha);
                cmd.Parameters.AddWithValue("@Email", objEdita.Email);
                cmd.Parameters.AddWithValue("@Instagram", objEdita.Instagram);
                cmd.Parameters.AddWithValue("@Twitter", objEdita.Twitter);
                cmd.Parameters.AddWithValue("@Discord", objEdita.Discord);
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
        public void ExcluirDesenvolvedor(int objDel)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Desenvolvedor SET Status = 0 WHERE IdDesenvolvedor = @IdDesenvolvedor;", conn);
                cmd.Parameters.AddWithValue("@IdDesenvolvedor", objDel);
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





        //Buscando por ID
        public DesenvolvedorDTO BuscarDesenvolvedorPorID(int objIdDesenvolvedor)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Desenvolvedor WHERE IdDesenvolvedor = @IdDesenvolvedor;", conn);
                cmd.Parameters.AddWithValue("@IdDesenvolvedor", objIdDesenvolvedor);
                dr = cmd.ExecuteReader();
                DesenvolvedorDTO obj = new DesenvolvedorDTO();
                if (dr.Read())
                {
                    obj = new DesenvolvedorDTO();
                    obj.IdDesenvolvedor = Convert.ToInt32(dr["IdDesenvolvedor"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Instagram = dr["Instagram"].ToString();
                    obj.Twitter = dr["Twitter"].ToString();
                    obj.Discord = dr["Discord"].ToString();
                    obj.Status = Convert.ToBoolean(dr["Status"]);
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception($"Desenvolvedor não existe! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }
    }
}