using Microsoft.AspNetCore.Mvc;
using findPet.Models;
using System.Text.Json;
using Newtonsoft.Json;

namespace findPet.Controllers
{
    public class TelaFeedController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (TempData.ContainsKey("TelaPublicacaoModel"))
            {
                // Recupera os dados do TempData
                var model = JsonConvert.DeserializeObject<TelaPublicacaoFeed>((string)TempData["TelaPublicacaoModel"]);

                return View(model);
            }

            TelaPublicacaoFeed feed = new();
            return View(feed);

        }

        [HttpPost]
        public IActionResult Create(TelaFeedModel model)
        {
            // Aqui você pode processar os dados do formulário, salvar no banco, etc.

            // Redireciona para a TelaCadastro2 após o submit
            return RedirectToAction("Index", "TelaPublicacao");
        }

    }
}
