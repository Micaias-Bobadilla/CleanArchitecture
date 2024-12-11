using CA_ApplicationLayer;
using CA_InterfaceAdapter_Repository;
using CA_InterfaceAdapters_Data;
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
    options.UseOracle(DesverAes.GetConnectionString( builder.Configuration.GetConnectionString("OracleConn")));
});
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<GetBeerUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/beer", async (GetBeerUseCase beerUserCase) =>
{
    return await beerUserCase.ExecuteAsync();
})
.WithName("beers")
.WithOpenApi();

app.Run();

