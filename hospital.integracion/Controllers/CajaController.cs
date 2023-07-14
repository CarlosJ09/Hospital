using hospital.integracion.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace hospital.integracion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CajaController : Controller
    {
        private readonly CajaAPIDbContext cajaAPIDbContext;

        public CajaController(CajaAPIDbContext cajaAPIDbContext)
        {
            this.cajaAPIDbContext = cajaAPIDbContext;
        }

        [HttpGet("Clientes")]
        public IActionResult Clientes()
        {
            var clientes = cajaAPIDbContext.CLIENTE.ToList();
            return Ok(clientes);
        }

        [HttpGet("Cliente")]
        public IActionResult Cliente(int? id)
        {
            var cliente = cajaAPIDbContext.CLIENTE.Find(id);
            return Ok(cliente);
        }

        [HttpGet("Reporte")]
        public IActionResult Reporte()
        {
            var reporte = cajaAPIDbContext.REPORTE.ToList();
            return Ok(reporte);
        }

    }
}
