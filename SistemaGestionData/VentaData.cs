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
            VentaData.ModificarVenta(venta);
        }
        public static void EliminarVenta(Venta venta)
        {
            VentaData.EliminarVenta(venta);
        }
    }
}
