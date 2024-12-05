using CA_ApplicationLayer;
using CA_EnterpiseLayer;
using CA_InterfaceAdapters_Data;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapter_Repository
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _dbContext;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Beer beer)
        {
            await _dbContext.Beers.AddAsync(beer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Beer>> GetAllAsync()
        {
            return await _dbContext.Beers.ToListAsync();
        }

        public async Task<Beer> GetByIdAsyc(int id)
        {
            return await _dbContext.Beers.FindAsync(id);
        }
    }
}
