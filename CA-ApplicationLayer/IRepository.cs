using CA_EnterpiseLayer;

namespace CA_ApplicationLayer
{
    public interface IRepository
    {
        Task<Beer> GetByIdAsyc(int id);
        Task<IEnumerable<Beer>> GetAllAsync();
        Task AddAsync(Beer beer);
    }
}
