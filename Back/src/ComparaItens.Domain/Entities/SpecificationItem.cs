using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComparaItens.Domain.Entities
{
    public class SpecificationItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        //public List<CharacteristicDescription> CharacteristicDescriptions { get; set; }
    }
}