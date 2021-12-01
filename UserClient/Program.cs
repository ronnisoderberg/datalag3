using System.Threading.Channels;
using DataLayer.Backend;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;


bool loop = true;
int input;
int idVal;
var optionsBuilder = new DbContextOptionsBuilder();
optionsBuilder.UseSqlServer(
    "Data Source=(localdb)\\MSSQLLocalDB;Database=FoodpackTestDbContext");


var resturant = new RestaurantBackend(optionsBuilder.Options);
var user = new UserBackend(optionsBuilder.Options);
var userlogin = user.GetCostumer(1);

while (loop)
{
    Console.Clear();
    Console.WriteLine("Tryck 1 för att lista alla oköpta matlådor:");
    Console.WriteLine("Tryck 2 för att köpa en matlåda med ett ID:");
    Console.WriteLine("Tryck 3 för att se alla jag köpt:");
    input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case 1:
            var listaOkpta = user.GetFoodpackages("meat");
            listaOkpta.ForEach( x => Console.WriteLine(x) );

            Console.WriteLine("(tryck på valfri tangent)");
            Console.ReadKey();


        break;
        case 2:
            
            var listaOkptaAttKopa = user.GetFoodpackages("meat");
            listaOkptaAttKopa.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"Skriv Id på den du vill köpa: ");
            idVal = Convert.ToInt32(Console.ReadLine());

            if (listaOkptaAttKopa.Any(x=>x.Id == idVal))
            {
                Console.WriteLine("Giltigt val");
                var foodpacks = new List<Foodpackage>();
                foodpacks.Add(listaOkptaAttKopa.FirstOrDefault(x => x.Id == idVal));
                user.BuyFoodpack(foodpacks);


            }
            else
            {
                Console.WriteLine("Ogiltigt val, börja om.");
            }

            Console.WriteLine("(tryck på valfri tangent)");
            Console.ReadKey();

            break;


        case 3:
            Console.WriteLine("Dina köpta matlådor ");

            var listKöpta = user.GetFoodpackagesForCostummer(userlogin.Id);
            listKöpta.ForEach(x => Console.WriteLine(x));


            Console.WriteLine("(tryck på valfri tangent)");
            Console.ReadKey();
            break;

        default:
            loop = false;
            break;
    }
}


/* TODO
    "CustomerClient" där kunden genom input/UI kan:
Klar - titta på en lista på alla oköpta matlådor i alla restauranger av en viss typ (kött/fisk/vego), sorterade på pris, lägst först
    välja att köpa en av de lunchlådor som visas
    välja att se de matlådor denne köpt hittils

*/
