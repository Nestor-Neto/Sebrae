using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class ContaViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Descricao { get; set; }
    }
}
