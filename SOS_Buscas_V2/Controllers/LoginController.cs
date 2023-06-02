using Microsoft.AspNetCore.Mvc;
using SOS_Buscas_V2.Models;
using SOS_Buscas_V2.Repositorio;

namespace SOS_Buscas_V2.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuario _usuario;
        public LoginController(IUsuario usuario)
        {
            _usuario = usuario;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VerificarLogin(UsuarioModel usuario)
        {
            UsuarioModel usuarios = _usuario.VerificarLogin(usuario.Email);

            if (usuarios != null && usuarios.VerificarSenha(usuario.Senha))
            {
                    return Json(new { Msg = "Logado com sucesso"});  
            }

            return Json(new { Msg = "erro"});
        }
    }
}
