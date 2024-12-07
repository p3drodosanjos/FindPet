using Microsoft.AspNetCore.Mvc;
using findPet.Models;
using Newtonsoft.Json;

namespace findPet.Controllers
{
    public class TelaPublicacaoController : Controller
    {
        [HttpPost]
        public IActionResult Create(TelaPublicacaoModel model)
        {
            if (model != null)
            {
                if (model.Imagem != null && model.Imagem.Length > 0)
                {
                    var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Imagem");
                    Directory.CreateDirectory(uploadFolder);

                    var fileNameId = Guid.NewGuid().ToString() + "_" + model.Imagem.FileName;
                    var filePath = Path.Combine(uploadFolder, fileNameId);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Imagem.CopyTo(fileStream);
                    }

                    model.ImageFileName = fileNameId;
                }

                TempData["TelaPublicacaoModel"] = JsonConvert.SerializeObject(model);
                return RedirectToAction("Index", "TelaFeed");
            }

            return BadRequest();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}