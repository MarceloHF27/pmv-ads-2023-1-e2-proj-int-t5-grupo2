using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using SOS_Buscas.Models;
using SOS_Buscas.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace SOS_Buscas.Controllers
{
    
    public class CadastroController : Controller
    {
        private readonly ICadastro _cadastro;
        public CadastroController(ICadastro cadastro)
        {
            _cadastro = cadastro;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(User usuario)
        {
            List<User> users = _cadastro.Verificar();

            string email = usuario.Email;


            if (users != null && users.Any())
            {
                foreach (User user in users) 
                {
                    if (user.Email == email)
                    {
                        return Json(new { Msg = "erro" });
                    }
                }
                _cadastro.Adicionar(usuario);
                

            }
            return RedirectToAction("index");




        }
    }
}
