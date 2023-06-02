using Microsoft.EntityFrameworkCore;

using SOS_Buscas_V2.Models;

namespace SOS_Buscas_V2.Data
{
    public class BancoContext : DbContext
    {

        
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
