using SOS_Buscas.Models;

namespace SOS_Buscas.Repositorio
{
    public interface ILogin
    {


        User VerificarLogin(string email);


    }
}
