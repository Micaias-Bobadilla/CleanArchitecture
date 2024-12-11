using CA_EnterpiseLayer;

namespace CA_ApplicationLayer
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsyc(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(Beer beer);
    }
}
