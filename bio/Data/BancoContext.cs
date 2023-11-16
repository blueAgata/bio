using Microsoft.EntityFrameworkCore;
using rede_social.models;


namespace rede_social.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
