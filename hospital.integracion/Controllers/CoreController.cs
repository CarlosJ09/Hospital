using Microsoft.AspNetCore.Mvc;

namespace hospital.integracion.Controllers
{
  
    public class CoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
