﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entidades
{
    public class Endereço : BaseEntity
    {
        [MaxLength(80)]
        public string Rua { get; set; }
        [MaxLength(50)]
        public string Bairro { get; set; }
        [MaxLength(60)]
        public int Cidade { get; set; }
        [MaxLength(2)]
        public string Estado { get; set; }
        public int Numero { get; set; }

        public long EscolaId { get; set; }
        public Escola Escola { get; set; }
    }
}
