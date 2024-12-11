using CA_ApplicationLayer;
using CA_EnterpiseLayer;
using CA_InterfaceAdaptares_Mappers.Dtos.Request;

namespace CA_InterfaceAdaptares_Mappers
{
    public class BeerMapper : IMapper<BeerRequestDTO, Beer>
    {
        public Beer ToEntity(BeerRequestDTO beer)
            => new Beer()
            {
                Id = beer.Id,
                Name = beer.Name,
                Style = beer.Style,
                Alcohol = beer.Alcohol
            };
    }
}
