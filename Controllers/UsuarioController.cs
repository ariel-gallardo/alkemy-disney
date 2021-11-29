using alkemy_challenge.Models;
using alkemy_challenge.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace alkemy_challenge.Controllers
{
    [Route("auth")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<string> LoguearUsuario([FromBody]Usuario usuario){
            try{
                string tempU = UsuarioService.Loguear(usuario);
                return tempU;
            }catch(Exception e){
                return NotFound();
            }
        }
    }
}