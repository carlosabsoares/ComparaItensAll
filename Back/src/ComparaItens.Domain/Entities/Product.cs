using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComparaItens.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int ManufacturerId { get; set; }

        public string Model { get; set; }

        public int CategoryId { get; set; }

        [Range(1900, 3000, ErrorMessage = "Valor inválido.")]
        public int YearOfManufacture { get; set; }

        public string Image { get; set; }
        
        public string Folder { get; set; }

        [NotMapped]
        public Manufacturer Manufecturer { get; set; }

        [NotMapped]
        public Category Category { get; set; }

        [NotMapped]
        public IList<CharacteristicDescription> CharacteristicDescriptions { get; set; }

        public Product()
        {
        }
    }
}