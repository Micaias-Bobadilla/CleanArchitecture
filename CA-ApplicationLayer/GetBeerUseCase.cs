namespace CA_ApplicationLayer
{
    public class GetBeerUseCase<T>
    {
        private readonly IRepository<T> _beerRepository;

        public GetBeerUseCase(IRepository<T> beerRepository)
        {
            _beerRepository = beerRepository;
        }

        public async Task<IEnumerable<T>> ExecuteAsync()
        {
            return await _beerRepository.GetAllAsync();
        }
    }
}
