using System;
using System.ComponentModel.DataAnnotations;

namespace ApiConfitec.Domain.Entitys
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public int Escolaridade { get; set; }
    }
}
