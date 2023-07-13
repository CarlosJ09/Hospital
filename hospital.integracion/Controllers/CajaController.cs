using Microsoft.AspNetCore.Mvc;

namespace hospital.integracion.Controllers
{
    [ApiController]
    public class CajaController : Controller
    {
        [HttpGet("Clientes")]
        public IActionResult AllClients()
        {
            var response = "Clients";
            return Ok(response);
        }

        [HttpGet("Usuarios")]
        public async Task<IActionResult> AllUsuarios()
        {
            var response = "Usuarios";
            return Ok(response);
        }
    }
}
