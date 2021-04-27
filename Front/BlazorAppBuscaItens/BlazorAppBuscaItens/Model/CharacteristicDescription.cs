namespace BlazorAppBuscaItens.Model
{
    public class CharacteristicDescription
    {
        public int Id { get; set; }

        public int CharacteristicId { get; set; }

        public Characteristic Characteristics { get; set; }

        public int CharacteristicKeyId { get; set; }

        public CharacteristicKey CharacteristicKeys { get; set; }
    }
}