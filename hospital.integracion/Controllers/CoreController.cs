using Microsoft.AspNetCore.Mvc;

namespace hospital.integracion.Controllers
{
    [ApiController]
    [Produces("Application/Json")]
    [Route("api/[controller]")]
    public class CoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
