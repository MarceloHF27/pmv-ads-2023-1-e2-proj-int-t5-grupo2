using Microsoft.AspNetCore.Mvc;
using SOS_Buscas_V2.Helper;
using SOS_Buscas_V2.Models;
using SOS_Buscas_V2.Repositorio;

namespace SOS_Buscas_V2.Controllers
{
    public class LoginController : Controller
    {
        //----------------------------------------------------------------------
        //Construtor para a injeção de dependencias das interfaces IUsuario e ISessao
        private readonly IUsuario _usuario;
        private readonly ISessao _sessao;
        public LoginController(IUsuario usuario, ISessao sessao)
        {
            _usuario = usuario;
            _sessao = sessao;   
        }

        //----------------------------------------------------------------------
        //Metodo para chamar a pagina de login com a verificação para caso o usuário já esteja logado
        public IActionResult Index()
        {
            return View();
        }

        //----------------------------------------------------------------------
        //Loga o usuário no site iniciando a sessão
        public IActionResult VerificarLogin(UsuarioModel usuario)
        {
            UsuarioModel usuarios = _usuario.VerificarLogin(usuario.Email);

            if (usuarios != null && usuarios.VerificarSenha(usuario.Senha))
            {
                _sessao.CriarSessao(usuario);


                //Aqui precisamos de uma mensagem falando que o usuario foi logado
                return View("Index");
                    
                    
            }

            //Aqui precisamos de uma mensagem falando que ocorreu um erro no Login
            return View("Index");
        }

        public IActionResult Logout()
        {
            if (_sessao.BuscarSessao() == null) return Json(new { Msg = "Você não fez login" });
            _sessao.ApagarSessao();

            //Aqui precisamos de uma mensagem informando que o a sessão do usuario foi finalizada
            return View("Index");
        }
    }
}
