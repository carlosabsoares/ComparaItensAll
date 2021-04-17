using System.ComponentModel.DataAnnotations.Schema;

namespace ComparaItens.Domain.Entities
{
    public class ProductItem
    {
        public int ProductId { get; set; }
        public int CharacteristicDescriptionId { get; set; }

        [NotMapped]
        public Product Product { get; set; }

        [NotMapped]
        public CharacteristicDescription CharacteristicDescription { get; set; }
    }
}