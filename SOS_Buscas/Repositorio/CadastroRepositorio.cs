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


        public List<User> Verificar()
        {
            return _bancoContext.Usuario.ToList();
        }


        public User Adicionar(User usuario)
        {

            _bancoContext.Usuario.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        
    }
}
