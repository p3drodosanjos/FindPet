using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaCadastroController : Controller
    {
       [HttpPost]
    public IActionResult Create(telaCadastroModel model)
    {
        // Aqui você pode processar os dados do formulário, salvar no banco, etc.
        
        // Redireciona para a TelaCadastro2 após o submit
        return RedirectToAction("Index", "TelaCadastro2");
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    }
}