using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_InterfaceAdaptares_Mappers.Dtos.Request
{
    public class BeerRequestDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public decimal Alcohol { get; set; }
    }
}
