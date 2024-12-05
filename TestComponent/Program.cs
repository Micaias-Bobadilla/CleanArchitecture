using BusinessComponent;
using Microsoft.Extensions.DependencyInjection;
using RepositoryComponent;

var container = new ServiceCollection()
    .AddSingleton<IRepository, BeerRepository>()
    .AddTransient<BeerManager>()
    .BuildServiceProvider();


var beerManager = container.GetService<BeerManager>();
    beerManager.add("Heinekkend");
beerManager.add("Gasparin");
Console.WriteLine(beerManager.Get());
Console.ReadKey();

//clase Temporal
public class DefaultRepository : IRepository
{
    public void add(string beer)
    { }

    public string Get()
    => "algo";
}
