using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using bio.models;

namespace bio.Data.Map
{
    public class AmigosMap : IEntityTypeConfiguration<AmigosModel>
    {
        public void Configure(EntityTypeBuilder<AmigosModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.UsuarioSeguidor);
            builder.HasOne(x => x.UsuarioSeguido);
        }
    }
}
