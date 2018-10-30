using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Livros
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Editora")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "Ano")]
        public string Ano { get; set; }

        [Required(ErrorMessage = "Autor")]
        public string Autor { get; set; }

    }
}