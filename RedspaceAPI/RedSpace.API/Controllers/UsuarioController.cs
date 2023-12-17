using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Redspace.DTO;
using RedSpace.DAL;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedSpace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                var usuarios = usuarioDAL.ListarUsuarios();
                return Ok(usuarios);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao listar usuários.");
            }
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                var usuario = usuarioDAL.BuscaUsuarioPorId(id);
                return Ok(usuario);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao buscar usuário.");
            }
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public ActionResult Post([FromBody] UsuarioInputDTO usuario)
        {
            try
            {
                if (usuario == null)
                    return BadRequest("Os dados do usuário não foram preenchidos.");
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                UsuarioDTO usuarioDTO = new UsuarioDTO();
                usuarioDTO.Nome = usuario.Nome;
                usuarioDTO.Email = usuario.Email;
                usuarioDTO.Senha = usuario.Senha;
                if (usuarioDAL.VerificarUsuario(usuarioDTO.Email))
                {
                    return BadRequest("O usuário já existe.");
                }
                else
                {
                    usuarioDAL.CadastrarUsuario(usuarioDTO);
                    return Ok();
                }
            }
            catch (Exception)
            {
                return BadRequest("Erro ao cadastrar o usuário.");
            }
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] UsuarioInputDTO usuario)
        {
            try
            {
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                UsuarioDTO usuarioDTO = new UsuarioDTO();
                usuarioDTO.IdUsuario = id;
                usuarioDTO.Nome = usuario.Nome;
                usuarioDTO.Senha = usuario.Senha;
                usuarioDTO.Email = usuario.Email;
                usuarioDAL.EditarUsuario(usuarioDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Erro ao editar o usuário.");
            }


        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{IdUsuario}")]
        public ActionResult Delete(int IdUsuario)
        {
            try
            {
                int IdJogo = 0;
                UsuarioJogoDAL usuarioJogoDAL = new UsuarioJogoDAL();
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                usuarioDAL.ExcluirUsuario(IdUsuario);
                usuarioJogoDAL.ExcluirUsuarioJogo(IdJogo, IdUsuario);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Erro ao excluir o usuário");
            }
        }
    }
}
