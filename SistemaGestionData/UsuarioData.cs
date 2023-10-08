using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        public static List<Usuario> ListaUsuarios()
        {
            var db = new SistemaGestionContext();
            return db.Usuarios.OrderBy(x => x.Id).ToList();
        }
        public static Usuario ObtenerUsuarios(int IdUsuario)
        {
            var db = new SistemaGestionContext();
            return db.Usuarios.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdUsuario);
        }
        public static void CrearUsuario(Usuario usuario)
        {
            using (var context = new SistemaGestionContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }
        public static void ModificarUsuario(Usuario usuario)
        {
        }
        public static void EliminarUsuario(Usuario usuario)
        {
        }
    }
}
