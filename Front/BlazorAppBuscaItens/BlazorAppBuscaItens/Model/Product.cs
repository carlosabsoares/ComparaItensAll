using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppBuscaItens.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int ManufecturerId { get; set; }

        public string Model { get; set; }

        public int CategoryId { get; set; }

        public int YearOfManufacture { get; set; }
        public string Image { get; set; }
        public string Folder { get; set; }

        public IList<ProductItem> ProductItems { get; set; }

        public Manufacturer Manufecturer { get; set; }

        public Category Category { get; set; }
    }
}
