using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Entities
{
    public class SpecificationCharacteristcRel
    {
        public int SpecificationItemId { get; set; }
        public int CharacteristicDescriptionId { get; set; }
    }
}
