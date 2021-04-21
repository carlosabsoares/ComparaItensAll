using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
