using Microsoft.AspNetCore.Mvc;
using SOS_Buscas.Models;
using SOS_Buscas.Repositorio;

namespace SOS_Buscas.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILogin _login;
        public LoginController(ILogin login)
        {
            _login = login;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logar(Login usuario)
        {
            User usuarios = _login.VerificarLogin(usuario.Email);

            if (usuarios != null && usuarios.VerificarSenha(usuario.Senha))
            {
                    return Json(new { Msg = "sucesso" });  
            }

            return Json(new { Msg = "erro" });




        }
    }
}
