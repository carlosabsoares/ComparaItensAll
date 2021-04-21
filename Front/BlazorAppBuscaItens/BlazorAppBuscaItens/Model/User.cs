using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppBuscaItens.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Login é obrigatório")]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Nome é obrigatória")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é obrigatória")]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Perfil é obrigatório")]
        //[MaxLength(100)]
        //public string Role { get; set; }
    }
}
