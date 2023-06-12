using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SOS_Buscas_V2.Helper;
using SOS_Buscas_V2.Models;
using SOS_Buscas_V2.Repositorio;

namespace SOS_Buscas_V2.Controllers
{
    public class DesaparecidoController : Controller
    {
        //----------------------------------------------------------------------
        // Construtor para injeção de dependencia das Interfaces IDesaparecido e ISessao
        private readonly IDesaparecido _iDesaparecido;
        private readonly ISessao _iSessao;
        private readonly IEndereco _iEndereco;
        private readonly string _caminhoImagem;

        private int _IdDesaparecido;
        
        
        public DesaparecidoController(IDesaparecido iDesaparecido, ISessao iSessao, IWebHostEnvironment caminhoImagem, IEndereco iEndereco)
        {
            _iDesaparecido = iDesaparecido;
            _iSessao = iSessao;
            _caminhoImagem = caminhoImagem.WebRootPath;
            _iEndereco = iEndereco; 
        }

        //----------------------------------------------------------------------
        //Metodo para chamar a pagina Index
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ApagarPage(DesaparecidoModel desaparecido)
        {
            DesaparecidoModel desaparecidoDB = _iDesaparecido.ListarPorId(desaparecido.Id);
            return View(desaparecidoDB);
        }


        public IActionResult EditarPage(DesaparecidoModel desaparecido)
        {
            DesaparecidoModel desaparecidoDB = _iDesaparecido.ListarPorId(desaparecido.Id);
            return View(desaparecidoDB);
        }

        //----------------------------------------------------------------------
        //Metodo para editar informações do desaparecido cadastrado

        
        [HttpPost]
        public IActionResult Editar(DesaparecidoModel desaparecido)
        {
            DesaparecidoModel desaparecidoDB = _iDesaparecido.Editar(desaparecido);
            
            if(desaparecidoDB != null ) 
            {
                return Json(new { Msg = "ecereto" });
            }
            return Json(new { Msg = "erro" });


        }

        //----------------------------------------------------------------------
        //Metodo para chamar a pagina de cadastro de desaparecidos


        public IActionResult CadastrarPage()
        {
            return View();
        }

        public IActionResult CadastrarEnderecoPage()
        {
            return View();
        }

        //----------------------------------------------------------------------
        //Metodo para verificar se o desaparecido já foi cadastrado e caso não tenha sido cadastrar o mesmo

        [HttpPost]
        public IActionResult Cadastrar(DesaparecidoModel desaparecido, IFormFile foto)
        {

            //------------------------------------------------------------------
            //Gera o nome da imagem do desaparecido e cadastra esse nome no banco

            string CaminhoDaImagem = _caminhoImagem + "\\Imagens\\";
            string nomeImagem = Guid.NewGuid().ToString() + "_" + foto.FileName;

            if (!Directory.Exists(CaminhoDaImagem))
            {
                Directory.CreateDirectory(CaminhoDaImagem);
            }

            using (var stream = System.IO.File.Create(CaminhoDaImagem + nomeImagem))
            {
                foto.CopyToAsync(stream);
            }

            desaparecido.CaminhoImagem = nomeImagem;

            //------------------------------------------------------------------
            // Informa para a DesaparecidoModel qual é o email do usuário que esta cadastrando o desaparecido
            UsuarioModel usuario = _iSessao.BuscarSessao();

            string EmailUsuario = usuario.Email;

            desaparecido.EmailUsuario = EmailUsuario;
            //------------------------------------------------------------------
            //Verifica e cadastra o desaparecido no banco

            _IdDesaparecido = desaparecido.Id;

            List<DesaparecidoModel> desaparecidos = _iDesaparecido.Listar();

            if (desaparecidos != null && desaparecidos.Any())
            {
                foreach (DesaparecidoModel missing in desaparecidos)  //Verifica se o desaparecido já foi cadastrado
                {
                    if (missing.NomeCompleto == desaparecido.NomeCompleto )
                    {
                        return Json(new { Msg = "esse usuario já existe" });
                    }
                }
                _iDesaparecido.Criar(desaparecido);   //Cadastra o desaprecido no banco
                return View("CadastrarEnderecoPage");
            }
            
            _iDesaparecido.Criar(desaparecido);    //Cadastrar o desaparecido no banco
            return View("CadastrarEnderecoPage");
        }



        //------------------------------------------------------------------
        //Retorna os dados dos desaparecidos para a montagem dos cards


        private List<DesaparecidoModel> _desaparecido;     //Variavel que recebe uma lista com os dados dos desaparecidos
        public IActionResult DesaparecidosPage()
        {
            List<DesaparecidoModel> desaparecidos = _iDesaparecido.Listar();
            _desaparecido = desaparecidos;

            foreach (DesaparecidoModel desaparecido in _desaparecido)      //Laço de repetição que cria os dados das colunas
            {
                List<DesaparecidoModel> dadosDesaparecido = _iDesaparecido.Listar();
                return View(dadosDesaparecido);
            }

            return View();
        }

        public IActionResult Apagar(DesaparecidoModel desaparecido)
        {
            bool desaparecidoDB = _iDesaparecido.Apagar(desaparecido);

            if(desaparecidoDB == true)
            {
                return Json(new { Msg = "Apagado com sucesso" });
            }
            return Json(new { Msg = "erro" });

        }

        public IActionResult CadastrarEndereco(EnderecoModel endereco)
        {
            List<EnderecoModel> enderecoDB = _iEndereco.Listar();
            
            


            //endereco.UserEmail = _UserEmail;

            UsuarioModel usuario = _iSessao.BuscarSessao();

            string EmailUsuario = usuario.Email;

            endereco.UserEmail = EmailUsuario;


            DesaparecidoModel desaparecido = _iDesaparecido.ListarPorId(_IdDesaparecido);

            int idDesaparecido = desaparecido.Id;

            endereco.DesaparecidoId = idDesaparecido;





            if (enderecoDB != null && enderecoDB.Any())
            {

                foreach(EnderecoModel enderecoModel in enderecoDB)
                {
                    if(endereco.Rua == enderecoModel.Rua && endereco.Numero == enderecoModel.Numero)
                    {
                        return Json(new { Msg = "erro" });
                    }
                    _iEndereco.Criar(endereco);
                    return Json(new { Msg = "Correto" });
                }
            }
            _iEndereco.Criar(endereco);
            return Json(new {Msg = "correto"});
        }


    }
}
