using Microsoft.AspNetCore.Mvc;
using RedSpace.DAL;
using Redspace.DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedSpace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    [EnableCors("MyPolicy")]
    public class ComentarioController : ControllerBase
    {
        // GET: api/<ComentarioController>
        [HttpGet("{idJogo}")]
        public ActionResult Get(int idJogo)
        {
            try
            {
                ComentarioDAL comentarioDAL = new ComentarioDAL();
                var comentarios = comentarioDAL.ListarComentarios(idJogo);
                return Ok(comentarios);
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao listar comentários.");
            }
        }

        // POST api/<ComentarioController>
        [HttpPost]
        public ActionResult Post([FromBody] ComentarioInputDTO comentario)
        {
            try
            {
                if (comentario == null)
                {
                    return BadRequest("Os dados não foram informados!");
                }
                ComentarioDAL comentarioDAL = new ComentarioDAL();
                ComentarioDTO comentarioDTO = new ComentarioDTO();
                comentarioDTO.IdUsuario = comentario.IdUsuario;
                comentarioDTO.IdJogo = comentario.IdJogo;
                comentarioDTO.Comentario = comentario.Comentario;
                comentarioDTO.Nota = comentario.Nota;
                comentarioDAL.CadastrarComentario(comentarioDTO);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocorreu um erro ao adicionar comentário.");
            }
        }



        // PUT api/<ComentarioController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ComentarioInputDTO comentario)
        {
            try
            {
                ComentarioDTO comentarioDTO = new ComentarioDTO();
                comentarioDTO.IdComentario = id;
                ComentarioDAL comentarioDAL = new ComentarioDAL();
                comentarioDTO.Comentario = comentario.Comentario;
                comentarioDTO.Nota = comentario.Nota;
                comentarioDAL.EditarComentario(comentarioDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao editar comentário.");
            }
        }



        // DELETE api/<ComentarioController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                ComentarioDAL comentarioDAL = new ComentarioDAL();
                comentarioDAL.ExcluirComentario(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao excluir comentário.");
            }
        }
    }
}
