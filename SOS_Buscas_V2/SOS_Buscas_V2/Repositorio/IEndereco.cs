using SOS_Buscas_V2.Models;

namespace SOS_Buscas_V2.Repositorio
{
    public interface IEndereco
    {
        public EnderecoModel ListarPorId(int id);
        public List<EnderecoModel> ListarPorEmail(string email);
        List<EnderecoModel> Listar();
        EnderecoModel Editar(EnderecoModel endereco);
        EnderecoModel Criar(EnderecoModel endereco);
        public bool Apagar(EnderecoModel endereco);

    }
}
