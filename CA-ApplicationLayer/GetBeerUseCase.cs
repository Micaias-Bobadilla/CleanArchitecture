using CA_EnterpiseLayer;

namespace CA_ApplicationLayer
{
    public class GetBeerUseCase
    {
        private readonly IRepository _beerRepository;

        public GetBeerUseCase(IRepository beerRepository)
        {
            _beerRepository = beerRepository;
        }

        public async Task<IEnumerable<Beer>> ExecuteAsync()
        {
            return await _beerRepository.GetAllAsync();
        }
    }
}
