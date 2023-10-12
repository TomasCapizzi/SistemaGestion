using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussines
{
    public static class ProductoVendidoBussines
    {
        public static List<ProductoVendido> ListaProductosVendidos()
        {
            return ProductoVendidoData.ListaProductosVendidos();
        }
        public static ProductoVendido ObtenerProductoVendido(int IdProductoVendido)
        {
            return ProductoVendidoData.ObtenerProductoVendido(IdProductoVendido);
        }
        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }
        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }
        public static void EliminarProductoVendido(int IdProductoVendido)
        {
            ProductoVendidoData.EliminarProductoVendido(IdProductoVendido);
        }
    }
}
