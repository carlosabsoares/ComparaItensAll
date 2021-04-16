using System.ComponentModel.DataAnnotations.Schema;

namespace ComparaItens.Domain.Entities
{
    public class CharacteristicDescription
    {
        public int Id { get; set; }

        public int CharacteristicId { get; set; }

        [NotMapped]
        public Characteristic Characteristics { get; set; }

        public int CharacteristicKeyId { get; set; }

        [NotMapped]
        public CharacteristicKey CharacteristicKeys { get; set; }
    }
}