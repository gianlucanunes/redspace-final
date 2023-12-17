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
    public class GaleriaController : ControllerBase
    {
        // GET: api/<GaleriaController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                GaleriaDAL galeriaDAL = new GaleriaDAL();
                var galerias = galeriaDAL.ListarGalerias();
                return Ok(galerias);
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao listar galerias.");
            }
        }



        // GET api/<GaleriaController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                GaleriaDAL galeriaDAL = new GaleriaDAL();
                var galerias = galeriaDAL.BuscarGaleriaPorID(id);
                return Ok(galerias);
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao selecionar galeria.");
            }
        }



        // POST api/<GaleriaController>
        [HttpPost]
        public ActionResult Post([FromBody] GaleriaInputDTO galeria)
        {
            try
            {
                if (galeria == null)
                {
                    return BadRequest("Os dados não foram informados!");
                }
                GaleriaDAL galeriaDAL = new GaleriaDAL();
                GaleriaDTO galeriaDTO = new GaleriaDTO();
                galeriaDTO.IdJogo = galeria.IdJogo;
                galeriaDTO.FotoPath = galeria.FotoPath;
                galeriaDAL.CadastrarGaleria(galeriaDTO);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocorreu um erro ao cadastrar galeria.");
            }
        }



        // PUT api/<GaleriaController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] GaleriaInputDTO galeria)
        {
            try
            {
                GaleriaDTO galeriaDTO = new GaleriaDTO();
                galeriaDTO.IdGaleria = id;
                GaleriaDAL galeriaDAL = new GaleriaDAL();
                galeriaDTO.FotoPath = galeria.FotoPath;
                galeriaDAL.EditarGaleria(galeriaDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao editar galeria.");
            }
        }



        // DELETE api/<GaleriaController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                GaleriaDAL galeriaDAL = new GaleriaDAL();
                galeriaDAL.ExcluirGaleria(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao excluir galeria.");
            }
        }
    }
}