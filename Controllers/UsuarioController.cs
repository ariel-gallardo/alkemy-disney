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
        public ActionResult<string> LoguearUsuario([FromBody]Usuario usuario){
            try{
                string token = UsuarioService.Loguear(usuario);
                return Ok(new{Mensaje = "Bienvenido", Token = token});
            }catch(Exception e){
                return NotFound(new {Mensaje = "Verificar los datos."});
            }
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public ActionResult RegistrarUsuario([FromBody] Usuario usuario)
        {
            if (UsuarioService.Registrar(usuario))
                return Ok(new { Mensaje = "Usuario creado exitosamente." });
            return NotFound(new { Mensaje = "Comprobar los datos" });
        }
    }
}