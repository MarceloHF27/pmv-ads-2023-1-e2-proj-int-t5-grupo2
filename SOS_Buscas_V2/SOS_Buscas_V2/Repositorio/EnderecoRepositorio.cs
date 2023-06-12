using SOS_Buscas_V2.Data;
using SOS_Buscas_V2.Models;

namespace SOS_Buscas_V2.Repositorio
{
    public class EnderecoRepositorio : IEndereco
    {
        private readonly BancoContext _bancoContext;
        public EnderecoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }


        public bool Apagar(EnderecoModel endereco)
        {
            EnderecoModel enderecoDB = ListarPorId(endereco.Id);

            if (enderecoDB == null)
            {
                throw new System.Exception("erro");
            }

            _bancoContext.Endereco.Remove(enderecoDB);
            _bancoContext.SaveChanges();
            return true;
        }


        //------------------------------------------------------------------
        //Salva os dados preenchidos no formulario no Banco de dados
        public EnderecoModel Criar(EnderecoModel endereco)
        {
            _bancoContext.Endereco.Add(endereco);
            _bancoContext.SaveChanges();
            return endereco;
        }

        public EnderecoModel Editar(EnderecoModel endereco)
        {
            throw new NotImplementedException();
        }

        //------------------------------------------------------------------
        //Edita as informações do Desaparecido



        //------------------------------------------------------------------
        //Lista os dados da tabela Desaparecidos presente Banco de dados
        public List<EnderecoModel> Listar()
        {
            return _bancoContext.Endereco.ToList();
        }

        public List<EnderecoModel> ListarPorEmail(string email)
        {
            throw new NotImplementedException();
        }


        //------------------------------------------------------------------
        //Lista os dados da tabela Desaparecidos presente Banco de dados que possuem o id informado a função

        public EnderecoModel ListarPorId(int id)
        {
            return _bancoContext.Endereco.FirstOrDefault(o => o.DesaparecidoId == id);

        }

        public List<EnderecoModel> ListarPorNome(string emailUser)
        {
            return _bancoContext.Endereco.Where(o => o.UserEmail.Equals(emailUser)).ToList();
        }
    }
}
