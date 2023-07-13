using Microsoft.AspNetCore.Mvc;

namespace hospital.integracion.Controllers
{
    [ApiController]
    [Produces("Application/Json")]
    [Route("api/[controller]")]
    public class CajaController : Controller
    {
        [HttpGet("AllClients")]
        public async Task<IActionResult> AllClients()
        {
            var response = "Clients";
            return Ok(response);
        }

        [HttpGet("AllUsuarios")]
        public async Task<IActionResult> AllUsuarios()
        {
            var response = "Usuarios";
            return Ok(response);
        }
    }
}
