using CA_ApplicationLayer;
using CA_EnterpiseLayer;
using CA_InterfaceAdapter_Repository;
using CA_InterfaceAdapters_Data;
using CA_InterfaceAdapters_Presenters;
using DesverAES;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//dependencias
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(DesverAes.GetConnectionString(builder.Configuration.GetConnectionString("DefaultConnections")));
});
builder.Services.AddScoped<IRepository<Beer>, Repository>();
builder.Services.AddScoped<IPresenter<Beer, BeerViewModel>, BeerPresenter>();
builder.Services.AddScoped<GetBeerUseCase<Beer, BeerViewModel>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/beer", async (GetBeerUseCase<Beer, BeerViewModel> beerUserCase) =>
{
    return await beerUserCase.ExecuteAsync();
})
.WithName("beers")
.WithOpenApi();

app.Run();

