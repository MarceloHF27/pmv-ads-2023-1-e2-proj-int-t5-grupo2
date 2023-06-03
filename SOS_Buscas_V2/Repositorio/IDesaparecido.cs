using SOS_Buscas_V2.Models;

namespace SOS_Buscas_V2.Repositorio
{
    public interface IDesaparecido
    {
        List<DesaparecidoModel> Listar();

        DesaparecidoModel Criar(DesaparecidoModel desaparecido);
    }
}
