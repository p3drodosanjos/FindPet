using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaPublicacaoController : Controller
    {
        [HttpPost]
        public IActionResult Create(TelaPublicacaoModel model)
        {
            return RedirectToAction("Index", "home");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}