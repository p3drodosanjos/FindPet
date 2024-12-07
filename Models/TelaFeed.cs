using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaFeedModel : Controller
    {
        [HttpPost]
        public IActionResult Create(TelaFeedModel model)
        {
            // Aqui voc� pode processar os dados do formul�rio, salvar no banco, etc.

            // Redireciona para a TelaCadastro2 ap�s o submit
            return RedirectToAction("Index", "TelaFeedModel");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}