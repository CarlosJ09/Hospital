using Microsoft.AspNetCore.Mvc;

namespace hospital.integracion.Controllers
{
   
    public class WebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
