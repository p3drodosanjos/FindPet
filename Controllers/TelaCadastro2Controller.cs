using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaCadastro2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(telaCadastro2Model model)
        {
            if (ModelState.IsValid)
            {
                // Aqui voc� pode processar os dados do formul�rio da TelaCadastro2
                return RedirectToAction("Success"); // Pode redirecionar para uma p�gina de sucesso
            }

            return View();
        }
    }
}