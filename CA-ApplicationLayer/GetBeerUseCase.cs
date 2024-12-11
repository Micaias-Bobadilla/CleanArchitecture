namespace CA_ApplicationLayer
{
    public class GetBeerUseCase<TEntity, TOuput>
    {
        private readonly IRepository<TEntity> _beerRepository;
        private readonly IPresenter<TEntity, TOuput> _presenter;

        public GetBeerUseCase(IRepository<TEntity> beerRepository, IPresenter<TEntity, TOuput> presenter)
        {
            _beerRepository = beerRepository;
            _presenter = presenter;
        }

        public async Task<IEnumerable<TOuput>> ExecuteAsync()
        {
            var beers = await _beerRepository.GetAllAsync();
            return _presenter.Present(beers);
        }
    }
}
