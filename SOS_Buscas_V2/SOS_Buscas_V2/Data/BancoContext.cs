using Microsoft.EntityFrameworkCore;

using SOS_Buscas_V2.Models;

namespace SOS_Buscas_V2.Data
{
    public class BancoContext : DbContext
    {

        //----------------------------------------------------------------------
        //Construtor criando a conexão com o banco de dados
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        //----------------------------------------------------------------------
        //Cria as tabelas presentes no banco
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<DesaparecidoModel> Desaparecidos { get; set; }
        public DbSet<AvistamentoModel> Avistamentos { get; set;}
        public DbSet<LocalAvistamentoModel> localAvistamentoModels { get; set; }
        public DbSet<EnderecoModel> Endereco { get; set; }
    }
}
