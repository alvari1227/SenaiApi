using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entidades
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
