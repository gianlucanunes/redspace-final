using Redspace.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpace.DAL
{
    public class CategoriaDAL : Conexao
    {
        //CREATE | Cadastro de Categoria
        public void CadastrarCategoria(CategoriaDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Categoria (Nome) VALUES (@Nome);", conn);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
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



        //READ | Listar Categorias
        public List<CategoriaDTO> ListarCategorias()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Nome, Status FROM Categoria;", conn);
                dr = cmd.ExecuteReader();
                List<CategoriaDTO> lista = new List<CategoriaDTO>();
                while (dr.Read())
                {
                    CategoriaDTO obj = new CategoriaDTO();
                    obj.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                    obj.Nome = dr["Nome"].ToString();
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



        //UPDATE | Editar ou atualizar a Categoria já existente
        public void EditarCategoria(CategoriaDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Categoria SET Nome = @Nome WHERE IdCategoria = @IdCategoria;", conn);
                cmd.Parameters.AddWithValue("@Nome", objEdita.Nome);
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
        public void ExcluirCategoria(int objDel)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Categoria SET Status = 0 WHERE IdCategoria = @IdCategoria;", conn);
                cmd.Parameters.AddWithValue("@IdCategoria", objDel);
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
        public CategoriaDTO BuscarCategoriaPorID(int objIdCategoria)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Categoria WHERE IdCategoria = @IdCategoria;", conn);
                cmd.Parameters.AddWithValue("@IdCategoria", objIdCategoria);
                dr = cmd.ExecuteReader();
                CategoriaDTO obj = new CategoriaDTO();
                if (dr.Read())
                {
                    obj = new CategoriaDTO();
                    obj.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Status = Convert.ToBoolean(dr["Status"]);
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception($"Categoria não encontrada! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
