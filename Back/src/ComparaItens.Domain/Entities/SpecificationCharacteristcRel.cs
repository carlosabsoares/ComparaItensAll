using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComparaItens.Domain.Entities
{
    public class SpecificationCharacteristcRel
    {
        public int SpecificationItemId { get; set; }
        public SpecificationItem SpecificationItem { get; set; }

        public int CharacteristicDescriptionId { get; set; }
        public CharacteristicDescription CharacteristicDescription { get; set; }

        //[NotMapped]
        //public IList<CharacteristicDescription> CharacteristicDescription { get; set; }

        
    }
}