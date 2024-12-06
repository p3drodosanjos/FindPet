using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaLoginController : Controller
    {
        [HttpPost]
        public IActionResult Login(TelaLoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Validação das credenciais do usuário
                bool usuarioValido = ValidarUsuario(model.Email, model.Senha);

                if (usuarioValido)
                {
                    // Redireciona para o dashboard ou página inicial após o login bem-sucedido
                    return RedirectToAction("Dashboard", "Home");
                }

                // Mensagem de erro para credenciais inválidas
                ModelState.AddModelError(string.Empty, "Email ou senha inválidos.");
            }

            // Retorna à tela de login com mensagens de erro
            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Retorna a view de login
            return View();
        }

        private bool ValidarUsuario(string email, string senha)
        {
            // Aqui você implementa a lógica de validação (banco de dados ou serviço externo)
            // Exemplo: Login válido com email e senha fixos para simulação
            return email == "teste@exemplo.com" && senha == "senha123";
        }
    }
}
