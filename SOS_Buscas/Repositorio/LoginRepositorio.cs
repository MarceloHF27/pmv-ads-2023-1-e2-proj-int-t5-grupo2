using SOS_Buscas.Data;
using SOS_Buscas.Models;

namespace SOS_Buscas.Repositorio
{
    public class LoginRepositorio : ILogin
    {
        private readonly BancoContext _bancoContext;
        public LoginRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public User VerificarLogin(string email)
        {
            return _bancoContext.Usuario.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
        }

        

    }
}
