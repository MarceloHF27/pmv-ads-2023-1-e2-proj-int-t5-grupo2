using SOS_Buscas.Data;
using SOS_Buscas.Models;

namespace SOS_Buscas.Repositorio
{
    public class CadastroRepositorio : ICadastro
    {
        private readonly BancoContext _bancoContext;
        public CadastroRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public User Adicionar(User usuario)
        {

            _bancoContext.Usuario.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }
    }
}
