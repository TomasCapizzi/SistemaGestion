using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussines;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return UsuarioBussines.ListaUsuarios().ToArray();
        }

        [HttpDelete(Name = "EliminarUsuario")]
        public void DeleteUsuario([FromBody] int Id)
        {
            UsuarioBussines.EliminarUsuario(Id);
        }

        [HttpPost(Name = "CrearUsuario")]
        public void PostUsuario([FromBody] Usuario usuario)
        {
            UsuarioBussines.CrearUsuario(usuario);
        }

        [HttpPut(Name = "ModificarUsuario")]
        public void PutUsuario([FromBody] Usuario usuario)
        {
            UsuarioBussines.ModificarUsuario(usuario);
        }
    }
}
