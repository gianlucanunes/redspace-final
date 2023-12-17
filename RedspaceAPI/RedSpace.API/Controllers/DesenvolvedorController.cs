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
    public class DesenvolvedorController : ControllerBase
    {
        // GET: api/<DesenvolvedorController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                DesenvolvedorDAL desenvolvedorDAL = new DesenvolvedorDAL();
                var desenvolvedores = desenvolvedorDAL.ListarDesenvolvedores();
                return Ok(desenvolvedores);
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao listar desenvolvedores.");
            }
        }



        // GET api/<DesenvolvedorController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                DesenvolvedorDAL desenvolvedorDAL = new DesenvolvedorDAL();
                var desenvolvedor = desenvolvedorDAL.BuscarDesenvolvedorPorID(id);
                return Ok(desenvolvedor);
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao selecionar desenvolvedor.");
            }
        }



        // POST api/<DesenvolvedorController>
        [HttpPost]
        public ActionResult Post([FromBody] DesenvolvedorInputDTO desenvolvedor)
        {
            try
            {
                if (desenvolvedor == null)
                {
                    return BadRequest("Os dados não foram informados!");
                }
                DesenvolvedorDAL desenvolvedorDAL = new DesenvolvedorDAL();
                DesenvolvedorDTO desenvolvedorDTO = new DesenvolvedorDTO();
                desenvolvedorDTO.Nome = desenvolvedor.Nome;
                desenvolvedorDTO.Senha = desenvolvedor.Senha;
                desenvolvedorDTO.Email = desenvolvedor.Email;
                desenvolvedorDTO.Instagram = desenvolvedor.Instagram;
                desenvolvedorDTO.Twitter = desenvolvedor.Twitter;
                desenvolvedorDTO.Discord = desenvolvedor.Discord;
                desenvolvedorDAL.CadastrarDesenvolvedor(desenvolvedorDTO);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocorreu um erro ao cadastrar desenvolvedor.");
            }
        }



        // PUT api/<DesenvolvedorController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DesenvolvedorInputDTO desenvolvedor)
        {
            try
            {
                DesenvolvedorDTO desenvolvedorDTO = new DesenvolvedorDTO();
                desenvolvedorDTO.IdDesenvolvedor = id;
                DesenvolvedorDAL desenvolvedorDAL = new DesenvolvedorDAL();
                desenvolvedorDTO.Nome = desenvolvedor.Nome;
                desenvolvedorDTO.Senha = desenvolvedor.Senha;
                desenvolvedorDTO.Email = desenvolvedor.Email;
                desenvolvedorDTO.Instagram = desenvolvedor.Instagram;
                desenvolvedorDTO.Twitter = desenvolvedor.Twitter;
                desenvolvedorDTO.Discord = desenvolvedor.Discord;
                desenvolvedorDAL.EditarDesenvolvedor(desenvolvedorDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao editar desenvolvedor.");
            }
        }



        // DELETE api/<DesenvolvedorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                DesenvolvedorDAL desenvolvedorDAL = new DesenvolvedorDAL();
                desenvolvedorDAL.ExcluirDesenvolvedor(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao excluir desenvolvedor.");
            }
        }
    }
}