using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussines;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> GetVentas()
        {
            return VentaBussines.ListaVentas().ToArray();
        }

        [HttpDelete(Name = "EliminarVenta")]
        public void DeleteVenta([FromBody] int Id)
        {
            VentaBussines.EliminarVenta(Id);
        }

        [HttpPost(Name = "CrearVenta")]
        public void PostVenta([FromBody] Venta venta)
        {
            VentaBussines.CrearVenta(venta);
        }

        [HttpPut(Name = "ModificarVenta")]
        public void PutVenta([FromBody] Venta venta)
        {
            VentaBussines.ModificarVenta(venta);
        }
    }
}
