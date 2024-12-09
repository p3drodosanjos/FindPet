using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class SobreNosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
