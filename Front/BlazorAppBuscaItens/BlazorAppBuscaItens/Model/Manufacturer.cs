using System.ComponentModel.DataAnnotations;

namespace BlazorAppBuscaItens.Model
{
    public class Manufacturer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(150)]
        public string Description { get; set; }
    }
}