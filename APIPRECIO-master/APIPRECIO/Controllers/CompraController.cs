using APIPRECIO.Models;
using APIProductos.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPRECIO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {

        private readonly CompraDBContext _db;
        public CompraController(CompraDBContext db)
        {
            _db = db;
        }
        // GET: api/<CompraController>
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            //List<Compra> compras = await _db.Compra.Include("Producto").ToListAsync();
            var compras = (from compra in _db.Compra
                           join producto in _db.Producto on compra.IdProducto equals producto.IdProducto
                           join usuario in _db.Usuarios on compra.Nombre equals usuario.Nombre
                           select new
                           {
                               IdCompra = compra.IdCompra,
                               Codigo = compra.Codigo,
                               Nombre = producto.Nombre,
                               Comprador = usuario.Nombre,
                               Cantidad = compra.Cantidad,
                               FechaCompra = compra.FechaCompra,
                               PrecioTotal = compra.Cantidad * producto.Precio
                           }).ToList();
            return Ok(compras);
        }

        // GET api/<CompraController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CompraController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Compra value)
        {
            try
            {
                // Obtener el producto de la base de datos
                Producto producto = await _db.Producto.FindAsync(value.IdProducto);

                if (producto == null)
                {
                    return NotFound("Producto no encontrado");
                }
                if (producto.Cantidad >= value.Cantidad)
                {
                    producto.Cantidad -= value.Cantidad;
                  
                    _db.Producto.Update(producto);
                    await _db.SaveChangesAsync();

                    await _db.Compra.AddAsync(value);
                    await _db.SaveChangesAsync();

                    return Ok(value);
                }
                else
                {
                    
                    return RedirectToAction("Create", "CompraController"); 
                }
            }
            catch (Exception)
            {
                return BadRequest("Error al guardar la compra");
            }
        }


        // PUT api/<CompraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompraController>/5
        [HttpDelete("{IdCompra}")]
		public async Task<IActionResult> Delete(int IdCompra)
		{
			Compra compra = await _db.Compra.FirstOrDefaultAsync(x => x.IdCompra == IdCompra);
			if (compra != null)
			{
				_db.Compra.Remove(compra);
				await _db.SaveChangesAsync();
				return NoContent();
			}
			return BadRequest();

		}
	}
}
