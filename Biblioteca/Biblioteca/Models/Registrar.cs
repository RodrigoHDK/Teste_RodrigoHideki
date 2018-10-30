
namespace Biblioteca.Models
{    
    using System.ComponentModel.DataAnnotations;

    public partial class Registrar
    {
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150)]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(150, MinimumLength = 6)]
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }
        public string SenhaSalt { get; set; }
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Primeiro Nome: ")]
        public string PrimeiroNome { get; set; }

        [Required]
        [Display(Name = "Último Nome: ")]
        public string UltimoNome { get; set; }

        public string UserType { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
