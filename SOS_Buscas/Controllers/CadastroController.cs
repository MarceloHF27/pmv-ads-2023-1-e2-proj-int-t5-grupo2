using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using SOS_Buscas.Models;
using SOS_Buscas.Repositorio;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Cadastrar(User usuario)
        {
            String email = usuario.Email;

            MySqlConnection mySqlConnection = new MySqlConnection("Server=SAMUEL; Database=SOS_Buscas; User Id=sa; Password  = 1234");
            await mySqlConnection.OpenAsync();

            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = $"SELECT * FROM Usuario WHERE Email = '{email}'";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            if(await  reader.ReadAsync())
            {
                return Json(new { msg = "usuário já existente" });
            }
            else
            {
                _cadastro.Adicionar(usuario);
                
            }
            return RedirectToAction("index");


        }
    }
}
