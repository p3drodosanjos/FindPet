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
        public IActionResult Create(telaCadastro2Model model)
        {
        // Aqui você pode processar os dados do formulário, salvar no banco, etc.
        
        // Redireciona para a TelaCadastro2 após o submit
        return RedirectToAction("Index", "TelaLogin");
        }

        [HttpPost]
        public IActionResult Index(telaCadastro2Model model)
        {
            if (ModelState.IsValid)
            {
                // Aqui você pode processar os dados do formulário da TelaCadastro2
                return RedirectToAction("Success"); // Pode redirecionar para uma página de sucesso
            }

            return View();
        }
    }
}