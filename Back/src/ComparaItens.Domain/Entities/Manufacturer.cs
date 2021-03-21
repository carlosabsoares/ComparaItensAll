namespace ComparaItens.Domain.Entities
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Manufacturer()
        {
        }

        public Manufacturer(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public Manufacturer(string description)
        {
            Description = description;
        }

        public Manufacturer(int id)
        {
            Id = id;
        }
    }
}