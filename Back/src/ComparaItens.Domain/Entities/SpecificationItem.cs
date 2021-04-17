using System.Collections.Generic;

namespace ComparaItens.Domain.Entities
{
    public class SpecificationItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public List<SpecificationCharacteristcRel> SpecificationCharacteristcRels { get; set; }
    }
}