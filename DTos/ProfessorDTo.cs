using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTos
{
    public class ProfessorDTo
    {
        public long Id { get; set; }
        [MaxLength(30)]
        public string Nome { get; set; }

        public long EscolaId { get; set; }

    }
}
