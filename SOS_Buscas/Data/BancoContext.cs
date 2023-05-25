using Microsoft.EntityFrameworkCore;
using SOS_Buscas.Models;

namespace SOS_Buscas.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {  
        }

        public DbSet<User> Usuario { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<LocalAvistamento> LocalAvistamentos { get; set; }
        public DbSet<HistoricoAvistamento> HistoricoAvistamentos { get; set; }
        public DbSet<Familiar> Familiar { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Descricao> Descricao { get; set; }
        public DbSet<Desaparecido> Desaparecido { get; set; }

    }
}
