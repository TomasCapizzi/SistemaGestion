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
            using (var context = new SistemaGestionContext())
            {
                var usuarioEditado = context.Usuarios.Where(x => x.Id.Equals(usuario.Id)).Single();
                usuarioEditado.Nombre = usuario.Nombre;
                usuarioEditado.Apellido = usuario.Apellido;
                usuarioEditado.NombreUsuario = usuario.NombreUsuario;
                usuarioEditado.Contraseña = usuario.Contraseña;
                usuarioEditado.Mail = usuario.Mail;
                context.Entry(usuarioEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarUsuario(int IdUsuario)
        {
            using (var context = new SistemaGestionContext())
            {
                var usuario = context.Usuarios.Where(x => x.Id.Equals(IdUsuario)).Single();

                context.Remove(usuario);
                context.SaveChanges();
            }
        }
    }
}
