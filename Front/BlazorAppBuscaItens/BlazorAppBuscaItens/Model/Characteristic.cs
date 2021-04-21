using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppBuscaItens.Model
{
    public class Characteristic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(150)]
        public string Description { get; set; }
    }
}
