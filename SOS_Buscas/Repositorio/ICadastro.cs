using SOS_Buscas.Models;

namespace SOS_Buscas.Repositorio
{
    public interface ICadastro
    {
        List<User> Verificar();
        User Adicionar(User usuario);
    }
}
