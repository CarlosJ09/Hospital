using hospital.integracion.Data;
using Microsoft.AspNetCore.Mvc;

namespace hospital.integracion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoreController : Controller
    {
        private readonly CoreAPIDbContext coreAPIDbContext;

        public CoreController(CoreAPIDbContext coreAPIDbContext)
        {
            this.coreAPIDbContext = coreAPIDbContext;
        }

        [HttpGet("Inscritos")]
        public IActionResult Inscritos()
        {
            var ingreso = coreAPIDbContext.Ingreso.ToList();
            return Ok(ingreso);
        }

        [HttpGet("Inscrito")]
        public IActionResult Inscrito(int? id)
        {
            var ingreso = coreAPIDbContext.Ingreso.Find(id);
            return Ok(ingreso);
        }
    }
}
