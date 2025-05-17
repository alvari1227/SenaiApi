using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entidades
{
    public class Escola : BaseEntity
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }

        public Endereço Endereço { get; set; }

        public List<Professor> Professores { get; set; }

        public List<Classe> Classes { get; set; }

    }
}
