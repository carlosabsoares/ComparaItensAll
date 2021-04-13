using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComparaItens.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int ManufecturerId { get; set; }

        [NotMapped]
        public Manufacturer Manufecturer { get; set; }

        public string Model { get; set; }

        public int CategoryId { get; set; }

        [NotMapped]
        public Category Category { get; set; }

        public int YearOfManufacture { get; set; }
        public string Image { get; set; }
        public string Folder { get; set; }

        //public IList<SpecificationItem> SpecificationItems { get; set; }

        public Product()
        {
        }

        public Product(int id)
        {
            Id = id;
        }
    }
}