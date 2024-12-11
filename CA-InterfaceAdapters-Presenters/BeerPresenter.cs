using CA_ApplicationLayer;
using CA_EnterpiseLayer;

namespace CA_InterfaceAdapters_Presenters
{
    public class BeerPresenter : IPresenter<Beer, BeerViewModel>
    {
        public IEnumerable<BeerViewModel> Present(IEnumerable<Beer> beers)
        {
            return beers.Select(b => new BeerViewModel
            {
                Id = b.Id,
                Name = b.Name,
                Alcohol = b.Alcohol + "%"
            });
        }
    }
}
