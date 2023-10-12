using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussines
{
    public static class VentaBussines
    {
        public static List<Venta> ListaVentas()
        {
            return VentaData.ListaVentas();
        }
        public static Venta ObtenerVenta(int IdVenta)
        {
            return VentaData.ObtenerVenta(IdVenta);
        }
        public static void CrearVenta(Venta venta)
        {
            VentaData.CrearVenta(venta);
        }
        public static void ModificarVenta(Venta venta)
        {
            VentaData.ModificarVenta(venta);
        }
        public static void EliminarVenta(int IdVenta)
        {
            VentaData.EliminarVenta(IdVenta);
        }
    }
}
