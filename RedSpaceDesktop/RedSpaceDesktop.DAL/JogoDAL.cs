using RedSpaceDesktop.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RedSpaceDesktop.DAL
{
    public class JogoDAL : Conexao
    {
        // Cadastrando usuário
        public void CadastrarJogo(JogoDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Jogo (IdCategoria, IdDesenvolvedor, Nome, Descricao, Banner, DtLancamento, InstaladorPath) VALUES (@IdCategoria, @IdDesenvolvedor, @Nome, @Descricao, @Banner, @DtLancamento, @InstaladorPath)", conn);
                cmd.Parameters.AddWithValue("@IdCategoria", objCad.IdCategoria);
                cmd.Parameters.AddWithValue("@IdDesenvolvedor", objCad.IdDesenvolvedor);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@Descricao", objCad.Descricao);
                cmd.Parameters.AddWithValue("@Banner", objCad.Banner);
                cmd.Parameters.AddWithValue("@DtLancamento", objCad.DtLancamento);
                cmd.Parameters.AddWithValue("@InstaladorPath", objCad.InstaladorPath);
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
        public List<JogoDTO> ListarJogos()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdJogo, CAT.Nome AS Categoria, DEV.Nome AS Desenvolvedor, Jogo.Nome, Descricao, Banner, DtLancamento, InstaladorPath, Jogo.Status FROM Jogo INNER JOIN Categoria AS CAT ON CAT.IdCategoria = Jogo.IdCategoria INNER JOIN Desenvolvedor AS DEV ON DEV.IdDesenvolvedor = Jogo.IdDesenvolvedor", conn);
                dr = cmd.ExecuteReader();
                List<JogoDTO> lista = new List<JogoDTO>();
                while (dr.Read())
                {
                    JogoDTO obj = new JogoDTO();
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.IdCategoria = dr["Categoria"].ToString();
                    obj.IdDesenvolvedor = dr["Desenvolvedor"].ToString();
                    obj.Nome = dr["Nome"].ToString();
                    obj.Descricao = dr["Descricao"].ToString();
                    obj.Banner = dr["Banner"].ToString();
                    obj.DtLancamento = Convert.ToDateTime(dr["DtLancamento"]);
                    obj.InstaladorPath = dr["InstaladorPath"].ToString();
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

        public List<JogoDTO> ListarJogosPorCategoria(int idCategoria)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdJogo, CAT.Nome AS Categoria, DEV.Nome AS Desenvolvedor, Jogo.Nome, Descricao, Banner, DtLancamento, InstaladorPath, Jogo.Status FROM Jogo INNER JOIN Categoria AS CAT ON CAT.IdCategoria = Jogo.IdCategoria INNER JOIN Desenvolvedor AS DEV ON DEV.IdDesenvolvedor = Jogo.IdDesenvolvedor WHERE Jogo.IdCategoria = @IdCategoria", conn);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                dr = cmd.ExecuteReader();
                List<JogoDTO> lista = new List<JogoDTO>();
                while (dr.Read())
                {
                    JogoDTO obj = new JogoDTO();
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.IdCategoria = dr["Categoria"].ToString();
                    obj.IdDesenvolvedor = dr["Desenvolvedor"].ToString();
                    obj.Nome = dr["Nome"].ToString();
                    obj.Descricao = dr["Descricao"].ToString();
                    obj.Banner = dr["Banner"].ToString();
                    obj.DtLancamento = Convert.ToDateTime(dr["DtLancamento"]);
                    obj.InstaladorPath = dr["InstaladorPath"].ToString();
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

        public List<JogoDTO> PesquisaJogo(string nome)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdJogo, CAT.Nome AS Categoria, DEV.Nome AS Desenvolvedor, Jogo.Nome, Descricao, Banner, DtLancamento, InstaladorPath, Jogo.Status FROM Jogo INNER JOIN Categoria AS CAT ON CAT.IdCategoria = Jogo.IdCategoria INNER JOIN Desenvolvedor AS DEV ON DEV.IdDesenvolvedor = Jogo.IdDesenvolvedor WHERE Jogo.Nome LIKE '%' + @Nome + '%'", conn);
                cmd.Parameters.AddWithValue("@Nome", nome);
                dr = cmd.ExecuteReader();
                List<JogoDTO> lista = new List<JogoDTO>();
                while (dr.Read())
                {
                    JogoDTO obj = new JogoDTO();
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.IdCategoria = dr["Categoria"].ToString();
                    obj.IdDesenvolvedor = dr["Desenvolvedor"].ToString();
                    obj.Nome = dr["Nome"].ToString();
                    obj.Descricao = dr["Descricao"].ToString();
                    obj.Banner = dr["Banner"].ToString();
                    obj.DtLancamento = Convert.ToDateTime(dr["DtLancamento"]);
                    obj.InstaladorPath = dr["InstaladorPath"].ToString();
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

        public List<JogoDTO> ListarJogosRecemLancados()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT TOP 3 IdJogo, CAT.Nome AS Categoria, Jogo.Nome, Banner, DtLancamento, Jogo.Status FROM Jogo INNER JOIN Categoria AS CAT ON CAT.IdCategoria = Jogo.IdCategoria ORDER BY DtLancamento DESC", conn);
                dr = cmd.ExecuteReader();
                List<JogoDTO> lista = new List<JogoDTO>();
                while (dr.Read())
                {
                    JogoDTO obj = new JogoDTO();
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.IdCategoria = dr["Categoria"].ToString();
                    obj.Nome = dr["Nome"].ToString();
                    obj.Banner = dr["Banner"].ToString();
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

        public List<JogoDTO> ListarJogosDestaques()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT TOP 5 Jogo.IdJogo, Jogo.Nome, Jogo.Descricao, Jogo.Banner, COUNT(UsuarioJogo.IdUsuario) AS QuantidadeDownloads FROM Jogo INNER JOIN UsuarioJogo ON Jogo.IdJogo = UsuarioJogo.IdJogo WHERE Jogo.Status <> 0 GROUP BY Jogo.IdJogo, Jogo.Nome, Jogo.Descricao, Jogo.Banner ORDER BY QuantidadeDownloads DESC;", conn);
                dr = cmd.ExecuteReader();
                List<JogoDTO> lista = new List<JogoDTO>();
                while (dr.Read())
                {
                    JogoDTO obj = new JogoDTO();
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Descricao = dr["Descricao"].ToString();
                    obj.Banner = dr["Banner"].ToString();
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
        public void EditarJogo(JogoDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Jogo SET IdCategoria = @IdCategoria, IdDesenvolvedor = @IdDesenvolvedor, Nome = @Nome, Descricao = @Descricao, Banner = @Banner  WHERE IdJogo = @IdJogo", conn);
                cmd.Parameters.AddWithValue("@IdJogo", objEdita.IdJogo);
                cmd.Parameters.AddWithValue("@IdCategoria", objEdita.IdCategoria);
                cmd.Parameters.AddWithValue("@IdDesenvolvedor", objEdita.IdDesenvolvedor);
                cmd.Parameters.AddWithValue("@Nome", objEdita.Nome);
                cmd.Parameters.AddWithValue("@Descricao", objEdita.Descricao);
                cmd.Parameters.AddWithValue("@Banner", objEdita.Banner);
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
        public void ExcluirJogo(int objDel)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Jogo SET Status = 0 WHERE IdJogo = @IdJogo", conn);
                cmd.Parameters.AddWithValue("@IdJogo", objDel);
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
        public JogoDTO BuscaJogoPorId(int objIdJogo)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Jogo WHERE IdJogo = @IdJogo", conn);
                cmd.Parameters.AddWithValue("@IdJogo", objIdJogo);
                dr = cmd.ExecuteReader();
                JogoDTO obj = null;
                if (dr.Read())
                {
                    obj = new JogoDTO();
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.IdDesenvolvedor = dr["IdDesenvolvedor"].ToString();
                    obj.IdCategoria = dr["IdCategoria"].ToString();
                    obj.Nome = dr["Nome"].ToString();
                    obj.Descricao = dr["Descricao"].ToString();
                    obj.Banner = dr["Banner"].ToString();
                    obj.DtLancamento = Convert.ToDateTime(dr["DtLancamento"]);
                    obj.InstaladorPath = dr["InstaladorPath"].ToString();
                    obj.Status = Convert.ToBoolean(dr["Status"]);
                    return obj;
                }
                else
                {
                    return null;
                }

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

        //listas para combobox
        public List<CategoriaDTO> CarregaCategoria()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Categoria;", conn);
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

        public List<DesenvolvedorDTO> CarregaDesenvolvedor()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Desenvolvedor ORDER BY Nome ASC;", conn);
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
    }
}
