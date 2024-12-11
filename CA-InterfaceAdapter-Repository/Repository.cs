using CA_ApplicationLayer;
using CA_EnterpiseLayer;
using CA_InterfaceAdapters_Data;
using CA_InterfaceAdapters_Models;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapter_Repository
{
    public class Repository : IRepository<Beer>
    {
        private readonly AppDbContext _dbContext;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Beer beer)
        {
            var beerModel = new BeerModel()
            {
                Id = beer.Id,
                Name = beer.Name,
                Alcohol = beer.Alcohol,
                Style = beer.Style
            }; 

            await _dbContext.Beers.AddAsync(beerModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Beer>> GetAllAsync()
        {
            return await _dbContext.Beers.
                Select(b => new Beer
                {
                    Id = b.Id,
                    Style = b.Style,
                    Alcohol = b.Alcohol,
                    Name = b.Name
                }).ToListAsync();
        }

        public async Task<Beer> GetByIdAsyc(int id)
        {
            var beerModel= await _dbContext.Beers.FindAsync(id);

            return new Beer
            {
                Id = beerModel.Id,
                Name = beerModel.Name,
                Alcohol = beerModel.Alcohol,
                Style = beerModel.Style
            };
        }
    }
}
