using alkemy_challenge.Models;

namespace alkemy_challenge.Repositories
{
    public static class UsuarioRepository
    {
        public static List<Usuario> Usuarios = new List<Usuario>(){
            new Usuario {Id = 1, Nombre = "test1", Password = "test1", Rol = "Cliente"},
            new Usuario {Id = 2, Nombre = "test2", Password = "test2", Rol = "Cliente"},
            new Usuario {Id = 3, Nombre = "test3", Password = "test3", Rol = "Administrador"}
        };
        
        public static Usuario? GetUsuario(string usuario, string password){
            return Usuarios.Where(u => u.Nombre.Equals(usuario) && u.Password.Equals(password)).FirstOrDefault();
        }
    }
}