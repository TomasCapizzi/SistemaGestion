using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class VentaData
    {
        public static List<Venta> ListaVentas()
        {
            var db = new SistemaGestionContext();
            return db.Ventas.OrderBy(x => x.Id).ToList();
        }
        public static Venta ObtenerVenta(int IdVenta)
        {
            var db = new SistemaGestionContext();
            return db.Ventas.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdVenta);
        }
        public static void CrearVenta(Venta venta)
        {
            using (var context = new SistemaGestionContext())
            {
                context.Ventas.Add(venta);
                context.SaveChanges();
            }
        }
        public static void ModificarVenta(Venta venta)
        {
            using (var context = new SistemaGestionContext())
            {
                var ventaEditado = context.Ventas.Where(x => x.Id.Equals(venta.Id)).Single();
                ventaEditado.IdUsuario = venta.IdUsuario;
                ventaEditado.Comentarios = venta.Comentarios;
                context.Entry(ventaEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarVenta(int IdVenta)
        {
            using (var context = new SistemaGestionContext())
            {
                var venta = context.Ventas.Where(x => x.Id.Equals(IdVenta)).Single();

                context.Remove(venta);
                context.SaveChanges();
            }
        }
    }
}
