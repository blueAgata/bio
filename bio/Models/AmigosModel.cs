
namespace bio.models
{
    public class AmigosModel
    {
        public int Id { get; set; }
        public DateTime dataAmizade { get; set; }
        public int? SeguidorId { get; set; }

        public int? SeguidoId { get; set; }

        public UsuarioModel UsuarioSeguidor { get; set; }
        public UsuarioModel UsuarioSeguido { get; set; }

    }
}
