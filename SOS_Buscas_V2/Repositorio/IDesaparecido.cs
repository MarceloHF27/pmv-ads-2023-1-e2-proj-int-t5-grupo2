using SOS_Buscas_V2.Models;

namespace SOS_Buscas_V2.Repositorio
{
    public interface IDesaparecido
    {
        //------------------------------------------------------------------
        //Contratos do CRUD Desaparecidos

        public DesaparecidoModel ListarPorId(int id);
        public List<DesaparecidoModel> ListarPorNome(string nome);
        List<DesaparecidoModel> Listar();
        DesaparecidoModel Editar(DesaparecidoModel desaparecido);  
        DesaparecidoModel Criar(DesaparecidoModel desaparecido);
        public bool Apagar(DesaparecidoModel desaparecido);

        DesaparecidoModel EditarAvistamento(DesaparecidoModel desaparecido);
    }
}
