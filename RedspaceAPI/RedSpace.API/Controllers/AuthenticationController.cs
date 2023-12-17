using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Redspace.DTO;
using RedSpace.DAL;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RedSpace.API.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("Login")]
        public ActionResult Login([FromBody] Login user)
        {
            if (user is null)
            {
                return BadRequest("Invalid user request!!!");
            }
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            UsuarioDTO usuario = new UsuarioDTO();
            usuario = usuarioDAL.AutenticarUsuario(user.UserName, user.Password);
            if (usuario != null)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigurationManager.AppSetting["JWT:Secret"]));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: ConfigurationManager.AppSetting["JWT:ValidIssuer"],
                    audience: ConfigurationManager.AppSetting["JWT:ValidAudience"],
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: signinCredentials
                );
                DateTime expirationDate = tokeOptions.ValidTo;
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new JWTTokenResponse { Token = tokenString, IdUsuario = usuario.IdUsuario, DtExpiracao = expirationDate, NomeUsuario = usuario.Nome });
            }
            return Unauthorized();
        }
    }
}
