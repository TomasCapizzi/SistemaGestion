using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussines;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosVendidosController : ControllerBase
    {
        [HttpGet(Name = "GetProductosVendidos")]
        public IEnumerable<ProductoVendido> GetProductoVendidos()
        {
            return ProductoVendidoBussines.ListaProductosVendidos().ToArray();
        }

        [HttpDelete(Name = "EliminarProductoVendido")]
        public void DeleteProductoVendido([FromBody] int Id)
        {
            ProductoVendidoBussines.EliminarProductoVendido(Id);
        }

        [HttpPost(Name = "CrearProductoVendido")]
        public void PostProductoVendido([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussines.CrearProductoVendido(productoVendido);
        }

        [HttpPut(Name = "ModificarProductoVendido")]
        public void PutProductoVendido([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussines.ModificarProductoVendido(productoVendido);
        }
    }
}
