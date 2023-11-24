using Microsoft.EntityFrameworkCore;
using rede_social.Data.Map;
using rede_social.Models;

namespace rede_social.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) :
        base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<AmigosModel> Amigos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplicar configurações de mapeamento para AmigosModel
            modelBuilder.ApplyConfiguration(new AmigosMap());
            // Configurar a relação muitos-para-muitos entre UsuarioModel e
        modelBuilder.Entity<AmigosModel>()
        .HasOne(a => a.UsuarioSeguidor)
        .WithMany(u => u.Amigos)
        .HasForeignKey(a => a.SeguidorId)
        .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<AmigosModel>()
            .HasOne(a => a.UsuarioSeguido)
            .WithMany()
            .HasForeignKey(a => a.SeguidoId)
            .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
