using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppBuscaItens.Model
{
    public class ProductItem
    {
        public int ProductId { get; set; }
        public int CharacteristicDescriptionId { get; set; }

        public Product Product { get; set; }

        public CharacteristicDescription CharacteristicDescription { get; set; }
    }
}
