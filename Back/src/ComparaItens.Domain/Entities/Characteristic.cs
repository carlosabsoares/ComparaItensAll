using System.ComponentModel.DataAnnotations.Schema;

namespace ComparaItens.Domain.Entities
{
    public class Characteristic
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        [NotMapped]
        public Category Category { get; set; }
    }
}