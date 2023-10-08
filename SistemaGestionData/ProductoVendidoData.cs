using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {
        public static List<ProductoVendido> ListaProductosVendidos()
        {
            var db = new SistemaGestionContext();
            return db.ProductosVendidos.OrderBy(x => x.Id).ToList();
        }
        public static ProductoVendido ObtenerProductoVendido(int IdProductoVendido)
        {
            var db = new SistemaGestionContext();
            return db.ProductosVendidos.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdProductoVendido);
        }
        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            using (var context = new SistemaGestionContext())
            {
                context.ProductosVendidos.Add(productoVendido);
                context.SaveChanges();
            }
        }
        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }
        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.EliminarProductoVendido(productoVendido);
        }
    }
}
