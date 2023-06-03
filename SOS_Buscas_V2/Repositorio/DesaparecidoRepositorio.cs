using SOS_Buscas_V2.Data;
using SOS_Buscas_V2.Models;

namespace SOS_Buscas_V2.Repositorio
{
    public class DesaparecidoRepositorio : IDesaparecido

    {
        private readonly BancoContext _bancoContext;
        public DesaparecidoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }



        public DesaparecidoModel Criar(DesaparecidoModel desaparecido)
        {
            _bancoContext.Desaparecidos.Add(desaparecido);
            _bancoContext.SaveChanges();
            return desaparecido;
        }

        public List<DesaparecidoModel> Listar()
        {
            return _bancoContext.Desaparecidos.ToList();
        }
    }
}
