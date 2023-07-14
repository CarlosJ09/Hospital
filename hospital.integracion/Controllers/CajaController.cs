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

        [HttpGet("Usuarios")]
        public async Task<IActionResult> AllUsuarios()
        {
            var response = "Usuarios";
            return Ok(response);
        }
    }
}
