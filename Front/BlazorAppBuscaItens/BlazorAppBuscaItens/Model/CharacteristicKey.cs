using System.ComponentModel.DataAnnotations;

namespace BlazorAppBuscaItens.Model
{
    public class CharacteristicKey
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item é obrigatório")]
        [MaxLength(60)]
        public string Key { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatória")]
        [MaxLength(100)]
        public string Description { get; set; }
    }
}