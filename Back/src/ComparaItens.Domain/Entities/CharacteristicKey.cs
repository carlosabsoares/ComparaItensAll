using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComparaItens.Domain.Entities
{
    public class CharacteristicKey
    {
        public int Id { get; set; }
        //public string Key { get; set; }

        public string Description { get; set; }

        public int CharacteristicId { get; set; }

        [NotMapped]
        public Characteristic Characteristics { get; set; }
    }
}