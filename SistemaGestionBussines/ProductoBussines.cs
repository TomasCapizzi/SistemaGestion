using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;


namespace SistemaGestionBussines
{
    public static class ProductoBussines
    {
        public static List<Producto> ListaProductos()
        {
            return ProductoData.ListaProductos();
        }
        public static Producto ObtenerProducto(int IdProducto)
        {
            return ProductoData.ObtenerProducto(IdProducto);
        }
        public static void CrearProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }
        public static void ModificarProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }
        public static void EliminarProducto(Producto producto)
        {
            ProductoData.EliminarProducto(producto);
        }
    }
}
