using SOS_Buscas_V2.Models;

namespace SOS_Buscas_V2.Repositorio
{
    public interface IDesaparecido
    {

        public DesaparecidoModel ListarPorId(Guid id);
        List<DesaparecidoModel> Listar();

        DesaparecidoModel Criar(DesaparecidoModel desaparecido);
    }
}
