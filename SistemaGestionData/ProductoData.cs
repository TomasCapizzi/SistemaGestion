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
            using (var context = new SistemaGestionContext())
            {
                var productoEditado = context.Productos.Where(x => x.Id.Equals(producto.Id)).Single();
                productoEditado.Descripcion = producto.Descripcion;
                productoEditado.Costo = producto.Costo;
                productoEditado.PrecioVenta = producto.PrecioVenta;
                productoEditado.Stock = producto.Stock;
                productoEditado.IdUsuario = Convert.ToInt32(producto.IdUsuario);
                context.Entry(productoEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarProducto(int IdProducto)
        {
            using (var context = new SistemaGestionContext())
            {
                var producto = context.Productos.Where(x => x.Id.Equals(IdProducto)).Single();

                context.Remove(producto);
                context.SaveChanges();
            }
        }
    }
 }
