using Microsoft.EntityFrameworkCore;
using SOS_Buscas_V2.Data;
using SOS_Buscas_V2.Models;

namespace SOS_Buscas_V2.Repositorio
{

    public class DesaparecidoRepositorio : IDesaparecido
    {
        //------------------------------------------------------------------
        //Construtor para injetar o BancoContext

        private readonly BancoContext _bancoContext;
        public DesaparecidoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public bool Apagar(DesaparecidoModel desaparecido)
        {
            DesaparecidoModel desaparecidoDB = ListarPorId(desaparecido.Id);

            if(desaparecidoDB == null) 
            {
                throw new System.Exception("erro");
            }

            _bancoContext.Desaparecidos.Remove(desaparecidoDB);
            _bancoContext.SaveChanges();
            return true;
        }


        //------------------------------------------------------------------
        //Salva os dados preenchidos no formulario no Banco de dados
        public DesaparecidoModel Criar(DesaparecidoModel desaparecido)
        {
            _bancoContext.Desaparecidos.Add(desaparecido);
            _bancoContext.SaveChanges();
            return desaparecido;
        }

        //------------------------------------------------------------------
        //Edita as informações do Desaparecido
        public DesaparecidoModel Editar(DesaparecidoModel desaparecido)
        {
            DesaparecidoModel desaparecidoDB = ListarPorId(desaparecido.Id);

            if(desaparecidoDB == null) 
            {
                throw new System.Exception("erooouuu");
            }

            desaparecido.CPF = desaparecido.CPF;
            desaparecidoDB.NomeCompleto = desaparecido.NomeCompleto;
            desaparecidoDB.EstiloCorCabelo = desaparecido.EstiloCorCabelo;
            desaparecidoDB.CorPele = desaparecido.CorPele;
            desaparecidoDB.Altura = desaparecido.Altura;
            desaparecidoDB.Tatuagem = desaparecido.Tatuagem;

            desaparecidoDB.Vestimenta = desaparecido.Vestimenta;
            desaparecidoDB.DataHoraDesaparecimento = desaparecido.DataHoraDesaparecimento;

            desaparecidoDB.Medicacoes = desaparecido.Medicacoes;
            desaparecidoDB.Doencas = desaparecido.Doencas;
            desaparecidoDB.Transtornos = desaparecido.Transtornos;

            desaparecidoDB.NomeFamiliar = desaparecido.NomeFamiliar;
            desaparecidoDB.ContatoFamiliar = desaparecido.ContatoFamiliar;
            desaparecidoDB.GrauParentesco = desaparecido.GrauParentesco;
            desaparecidoDB.NomeFamiliar2 = desaparecido.NomeFamiliar2;
            desaparecidoDB.ContatoFamiliar2 = desaparecido.ContatoFamiliar2;
            desaparecidoDB.GrauParentesco2 = desaparecido.GrauParentesco2;


            desaparecidoDB.Endereco = desaparecido.Endereco;
            desaparecidoDB.Avistamento = desaparecido.Avistamento;

            desaparecidoDB.Observacoes = desaparecido.Observacoes;

            _bancoContext.Desaparecidos.Update(desaparecidoDB);
            _bancoContext.SaveChanges();
            return (desaparecidoDB);

        }

        public DesaparecidoModel EditarAvistamento(DesaparecidoModel desaparecido)
        {
            DesaparecidoModel desaparecidoDB = ListarPorId(desaparecido.Id);

            if (desaparecidoDB == null)
            {
                throw new System.Exception("erooouuu");
            }

            desaparecidoDB.CPF = desaparecido.CPF;
            desaparecidoDB.NomeCompleto = desaparecido.NomeCompleto;
            desaparecidoDB.EstiloCorCabelo = desaparecido.EstiloCorCabelo;
            desaparecidoDB.CorPele = desaparecido.CorPele;
            desaparecidoDB.Altura = desaparecido.Altura;
            desaparecidoDB.Tatuagem = desaparecido.Tatuagem;

            desaparecidoDB.Vestimenta = desaparecido.Vestimenta;
            desaparecidoDB.DataHoraDesaparecimento = desaparecido.DataHoraDesaparecimento;

            desaparecidoDB.Medicacoes = desaparecido.Medicacoes;
            desaparecidoDB.Doencas = desaparecido.Doencas;
            desaparecidoDB.Transtornos = desaparecido.Transtornos;

            desaparecidoDB.NomeFamiliar = desaparecido.NomeFamiliar;
            desaparecidoDB.ContatoFamiliar = desaparecido.ContatoFamiliar;
            desaparecidoDB.GrauParentesco = desaparecido.GrauParentesco;
            desaparecidoDB.NomeFamiliar2 = desaparecido.NomeFamiliar2;
            desaparecidoDB.ContatoFamiliar2 = desaparecido.ContatoFamiliar2;
            desaparecidoDB.GrauParentesco2 = desaparecido.GrauParentesco2;


            desaparecidoDB.Endereco = desaparecido.Endereco;
            desaparecidoDB.Avistamento = desaparecido.Avistamento;

            desaparecidoDB.Observacoes = desaparecido.Observacoes;

            _bancoContext.Desaparecidos.Update(desaparecidoDB);
            _bancoContext.SaveChanges();
            return (desaparecidoDB);
        }


        //------------------------------------------------------------------
        //Lista os dados da tabela Desaparecidos presente Banco de dados
        public List<DesaparecidoModel> Listar()
        {
            return _bancoContext.Desaparecidos.ToList();
        }


        //------------------------------------------------------------------
        //Lista os dados da tabela Desaparecidos presente Banco de dados que possuem o id informado a função

        public DesaparecidoModel ListarPorId(int id)
        {
            return _bancoContext.Desaparecidos.FirstOrDefault(o => o.Id == id);

        }

        public List<DesaparecidoModel> ListarPorNome(string nome)
        {
            return _bancoContext.Desaparecidos.Where(o => o.NomeCompleto.Equals(nome)).ToList();
        }


    }
}
