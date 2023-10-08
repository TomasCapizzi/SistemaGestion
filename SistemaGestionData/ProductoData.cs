using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class ProductoData
    {
        public static List<Producto> ListaProductos()
        {
            var db = new SistemaGestionContext();
            return db.Productos.OrderBy(x => x.Id).ToList();
        }
        public static Producto ObtenerProducto(int IdProducto)
        {
            var db = new SistemaGestionContext();
            return db.Productos.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdProducto);
        }
        public static void CrearProducto(Producto producto)
        {
            using (var context = new SistemaGestionContext())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }
        public static void ModificarProducto(Producto producto)
        {

        }
        public static void EliminarProducto(Producto producto)
        {

        }
    }
}
