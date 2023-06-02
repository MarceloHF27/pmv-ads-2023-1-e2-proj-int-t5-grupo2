using Microsoft.AspNetCore.Mvc;
using SOS_Buscas_V2.Data;
using SOS_Buscas_V2.Models;
using SOS_Buscas_V2.Repositorio;

namespace SOS_Buscas_V2.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IUsuario _usuario;
        public CadastroController(IUsuario usuario)
        {
            _usuario = usuario;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            List<UsuarioModel> users = _usuario.Listar(); 

            if(users != null && users.Any())
            {
                foreach(UsuarioModel user in users)
                {
                    if(user.Email == usuario.Email)
                    {
                        return Json(new { Msg = "esse usuario já existe" });
                    }
                }
                _usuario.Criar(usuario);
                return Json(new { Msg = "usuario criado com sucesso" });
            }

            return View("Index");
        }
    }
}
