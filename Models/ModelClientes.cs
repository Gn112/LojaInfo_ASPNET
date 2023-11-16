using System.ComponentModel.DataAnnotations;

namespace LojaInfo_ASPNET.Models
{
    public class ModelClientes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Endereco { get; set; }

    }
}
