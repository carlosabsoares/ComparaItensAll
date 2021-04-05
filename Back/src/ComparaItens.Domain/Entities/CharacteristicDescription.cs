using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Entities
{
    public class CharacteristicDescription
    {
        public int Id { get; set; }
        public int CharacteristicId { get; set; }
        public int CharacteristicKeyId { get; set; }
    }
}
