using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaFeedController : Controller
    {
        [HttpPost]
        public IActionResult Create(TelaFeedModel model)
        {
            // Aqui você pode processar os dados do formulário, salvar no banco, etc.

            // Redireciona para a TelaCadastro2 após o submit
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}