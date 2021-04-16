namespace ComparaItens.Domain.Entities
{
    public class SpecificationCharacteristcRel
    {
        public int SpecificationItemId { get; set; }

        public int CharacteristicDescriptionId { get; set; }

        //[NotMapped]
        //public IList<CharacteristicDescription> CharacteristicDescriptions { get; set; }
    }
}