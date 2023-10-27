using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

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
            using (var context = new SistemaGestionContext())
            {
                var productoVendidoEditado = context.ProductosVendidos.Where(x => x.Id.Equals(productoVendido.Id)).Single();
                productoVendidoEditado.IdProducto = Convert.ToInt32(productoVendido.IdProducto);
                productoVendidoEditado.Stock = productoVendido.Stock;
                productoVendidoEditado.IdVenta = Convert.ToInt32(productoVendido.IdVenta); 
                context.Entry(productoVendidoEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        
        public static void EliminarProductoVendido(int IdProductoVendido)
        {
            using (var context = new SistemaGestionContext())
            {
                var productoVendido = context.ProductosVendidos.Where(x => x.Id.Equals(IdProductoVendido)).Single();

                context.Remove(productoVendido);
                context.SaveChanges();
            }
        }
    }
}
