using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussines
{
    public static class UsuarioBussines
    {
        public static List<Usuario> ListaUsuarios()
        {
            return UsuarioData.ListaUsuarios();
        }
        public static Usuario ObtenerUsuarios(int IdUsuario)
        {
            return UsuarioData.ObtenerUsuarios(IdUsuario);
        }
        public static void CrearUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }
        public static void ModificarUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }
        public static void EliminarUsuario(Usuario usuario)
        {
            UsuarioData.EliminarUsuario(usuario);
        }
    }
}
