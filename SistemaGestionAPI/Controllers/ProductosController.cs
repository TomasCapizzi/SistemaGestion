using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussines;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        [HttpGet(Name = "GetProductos")]
        public IEnumerable<Producto> GetProductos()
        {
            return ProductoBussines.ListaProductos().ToArray();
        }

        [HttpDelete(Name = "EliminarProducto")]
        public void DeleteProducto([FromBody] int Id) { 
            ProductoBussines.EliminarProducto(Id);
        }

        [HttpPost(Name = "CrearProducto")]
        public void PostProduct([FromBody] Producto producto)
        {
            ProductoBussines.CrearProducto(producto);
        }

        [HttpPut(Name = "ModificarProducto")]
        public void PutProducto([FromBody] Producto producto)
        {
            ProductoBussines.ModificarProducto(producto);
        }
    }
}
 