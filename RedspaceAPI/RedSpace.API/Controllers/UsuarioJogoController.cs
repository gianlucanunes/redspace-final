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
    [Authorize]
    public class UsuarioJogoController : ControllerBase
    {
        // GET: api/<UsuarioJogoController>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                UsuarioJogoDAL usuarioJogoDAL = new UsuarioJogoDAL();
                var UsuariosJogos = usuarioJogoDAL.ListarUsuarioJogo(id);
                return Ok(UsuariosJogos);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao listar tabela UsuarioJogo.");
            }
        }

        [Route("api/[controller]/verificajogo")]
        [HttpGet]
        public string GetVerificacao(int IdUsuario, int IdJogo)
        {
            try
            {
                UsuarioJogoDAL usuarioJogoDAL = new UsuarioJogoDAL();

                if (usuarioJogoDAL.VerificaUsuarioJogo(IdUsuario, IdJogo))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                return "Erro ao verificar";
            }
        }

        // POST api/<UsuarioJogoController>
        [HttpPost]
        public ActionResult Post([FromBody] UsuarioJogoInputDTO usuarioJogo)
        {
            try
            {
                if (usuarioJogo == null)
                    return BadRequest("Preencha as informações.");
                UsuarioJogoDAL usuarioJogoDAL = new UsuarioJogoDAL();
                UsuarioJogoDTO usuarioJogoDTO = new UsuarioJogoDTO();
                usuarioJogoDTO.IdUsuario = usuarioJogo.IdUsuario;
                usuarioJogoDTO.IdJogo = usuarioJogo.IdJogo;
                usuarioJogoDTO.DataDownload = DateTime.Now;
                usuarioJogoDAL.CadastrarUsuarioJogo(usuarioJogoDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Erro ao cadastrar linha na tabela UsuarioJogo.");
            }
        }
    }
}
