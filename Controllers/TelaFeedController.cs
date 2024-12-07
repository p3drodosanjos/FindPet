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
            // Recupera os dados do TempData
            var model = JsonConvert.DeserializeObject<TelaPublicacaoFeed>((string)TempData["TelaPublicacaoModel"]);

            return View(model);
        }

    }
}
