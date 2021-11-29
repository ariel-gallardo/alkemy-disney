using alkemy_challenge.Models;
using alkemy_challenge.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace alkemy_challenge.Controllers
{
    [Route("auth")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost("login")]
        [AllowAnonymous]
        public ActionResult<Object> LoguearUsuario([FromBody]Usuario usuario){
            var tempU = UsuarioService.Loguear(usuario);
            if(tempU != null){
                return tempU;
            }
            return NotFound();
        }
    }
}