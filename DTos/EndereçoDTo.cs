using System.ComponentModel.DataAnnotations;
using WebApplication1.Entidades;

namespace WebApplication1.DTos
{
    public class EndereçoDTo
    {
        public long Id { get; set; }

        [MaxLength(80)]
        public string Rua { get; set; }
        [MaxLength(50)]
        public string Bairro { get; set; }
        [MaxLength(60)]
        public string Cidade { get; set; }
        [MaxLength(2)]
        public string Estado { get; set; }
        public int Numero { get; set; }

        public long EscolaId { get; set; }
      
    }
}
