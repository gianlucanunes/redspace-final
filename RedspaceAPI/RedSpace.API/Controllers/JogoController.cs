using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Redspace.DTO;
using RedSpace.DAL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedSpace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class JogoController : ControllerBase
    {
        // GET: api/<JogoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                
                JogoDAL jogoDAL = new JogoDAL();
                var jogos = jogoDAL.ListarJogos();
                return Ok(jogos);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao listar jogos.");
            }
        }

        // GET api/<JogoController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                JogoDAL jogoDAL = new JogoDAL();
                var jogo = jogoDAL.BuscaJogoPorId(id);
                return Ok(jogo);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao buscar o jogo.");
            }
        }

        // POST api/<JogoController>
        [HttpPost]
        public ActionResult Post([FromBody] JogoInputDTO jogo)
        {
            try
            {
                if (jogo == null)
                    return BadRequest("Os dados do jogo não foram preenchidos.");
                JogoDAL jogoDAL = new JogoDAL();
                JogoDTO jogoDTO = new JogoDTO();
                jogoDTO.IdCategoria = jogo.IdCategoria;
                jogoDTO.IdDesenvolvedor = jogo.IdDesenvolvedor;
                jogoDTO.Nome = jogo.Nome;
                jogoDTO.Descricao = jogo.Descricao;
                jogoDTO.Banner = jogo.Banner;
                jogoDTO.DtLancamento = jogo.DtLancamento;
                jogoDTO.InstaladorPath = jogo.InstaladorPath;
                jogoDAL.CadastrarJogo(jogoDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Erro ao cadastrar o jogo.");
            }
        }

        // PUT api/<JogoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] JogoInputDTO jogo)
        {
            try
            {
                JogoDAL jogoDAL = new JogoDAL();
                JogoDTO jogoDTO = new JogoDTO();
                jogoDTO.IdJogo = id;
                jogoDTO.IdCategoria = jogo.IdCategoria;
                jogoDTO.IdDesenvolvedor = jogo.IdDesenvolvedor;
                jogoDTO.Nome = jogo.Nome;
                jogoDTO.Descricao = jogo.Descricao;
                jogoDTO.Banner = jogo.Banner;
                jogoDTO.DtLancamento = jogo.DtLancamento;
                jogoDTO.InstaladorPath = jogo.InstaladorPath;
                jogoDAL.EditarJogo(jogoDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // DELETE api/<JogoController>/5
        [HttpDelete("{IdJogo}")]
        public ActionResult Delete(int IdJogo)
        {
            try
            {
                int IdUsuario = 0;
                UsuarioJogoDAL usuarioJogoDAL = new UsuarioJogoDAL();
                JogoDAL jogoDAL = new JogoDAL();
                jogoDAL.ExcluirJogo(IdJogo);
                usuarioJogoDAL.ExcluirUsuarioJogo(IdJogo, IdUsuario);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Route("carregajogosdestaques")]
        [HttpGet]
        public ActionResult GetJogosDestaques()
        {
            try
            {
                JogoDAL jogoDAL = new JogoDAL();
                var jogos = jogoDAL.ListarJogosDestaques();
                return Ok(jogos);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao listar jogos.");
            }
        }

        [Route("listajogosporcategoria")]
        [HttpGet]
        public ActionResult GetJogosPorCategoria(int id)
        {
            try
            {
                JogoDAL jogoDAL = new JogoDAL();
                var jogo = jogoDAL.ListarJogosPorCategoria(id);
                return Ok(jogo);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao buscar o jogo.");
            }
        }

        [Route("listajogosrecemlancados")]
        [HttpGet]
        public ActionResult GetJogosRecemLancados()
        {
            try
            {
                JogoDAL jogoDAL = new JogoDAL();
                var jogos = jogoDAL.ListarJogosRecemLancados();
                return Ok(jogos);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao listar jogos.");
            }
        }

        [Route("pesquisajogo")]
        [HttpGet]
        public ActionResult GetJogoPesquisa(string nome)
        {
            try
            {
                JogoDAL jogoDAL = new JogoDAL();
                var jogos = jogoDAL.PesquisaJogo(nome);
                return Ok(jogos);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao listar jogos.");
            }
        }
    }
}
