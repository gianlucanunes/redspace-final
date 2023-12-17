using Redspace.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RedSpace.DAL
{
    public class GaleriaDAL : Conexao
    {
        //CREATE | Criação de Galeria
        public void CadastrarGaleria(GaleriaDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Galeria (IdJogo, FotoPath) VALUES (@IdJogo, @FotoPath);", conn);
                cmd.Parameters.AddWithValue("@IdJogo", objCad.IdJogo);
                cmd.Parameters.AddWithValue("@FotoPath", objCad.FotoPath);
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

        //READ | Listar Galerias
        public List<GaleriaDTO> ListarGalerias()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT G.IdGaleria, J.Nome, G.FotoPath, G.Status FROM Galeria AS G INNER JOIN Jogo AS J ON J.IdJogo = G.IdJogo;", conn);
                dr = cmd.ExecuteReader();
                List<GaleriaDTO> lista = new List<GaleriaDTO>();
                while (dr.Read())
                {
                    GaleriaDTO obj = new GaleriaDTO();
                    obj.IdGaleria = Convert.ToInt32(dr["IdGaleria"]);
                    obj.IdJogo = dr["Nome"].ToString();
                    obj.FotoPath = dr["FotoPath"].ToString();
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

        //UPDATE | Editar ou atualizar uma Galeria já existente
        public void EditarGaleria(GaleriaDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Galeria SET FotoPath = @FotoPath WHERE IdGaleria = @IdGaleria;", conn);
                cmd.Parameters.AddWithValue("@IdGaleria", objEdita.IdGaleria);
                cmd.Parameters.AddWithValue("@FotoPath", objEdita.FotoPath);
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
        public void ExcluirGaleria(int objDel)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Galeria SET Status = 0 WHERE IdGaleria = @IdGaleria;", conn);
                cmd.Parameters.AddWithValue("@IdGaleria", objDel);
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
        public List<GaleriaDTO> BuscarGaleriaPorID(int objIdJogo)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdGaleria, IdJogo, FotoPath, Status FROM Galeria WHERE IdJogo = @IdJogo", conn);
                cmd.Parameters.AddWithValue("@IdJogo", objIdJogo);
                dr = cmd.ExecuteReader();
                List<GaleriaDTO> lista = new List<GaleriaDTO>();
                while (dr.Read())
                {
                    GaleriaDTO obj = new GaleriaDTO();
                    obj.IdGaleria = Convert.ToInt32(dr["IdGaleria"]);
                    obj.IdJogo = dr["IdJogo"].ToString();
                    obj.FotoPath = dr["FotoPath"].ToString();
                    obj.Status = Convert.ToBoolean(dr["Status"]);
                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception($"Galeria não existe! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }
    }
}