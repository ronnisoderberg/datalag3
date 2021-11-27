using DataLayer.Backend;


bool loop = true;
int input;

Console.WriteLine("val 1-3");
input = Convert.ToInt32(Console.ReadLine());
var resturant = new RestaurantBackend();
var user = new UserBackend();

while (loop)
{
    switch (input)
    {
        case 1:
            Console.WriteLine("input 1");
            var listaOkpta = user.GetFoodpackages("meat");
            loop=false;
        break;
        case 2:
            Console.WriteLine("input 2");
            loop = false;
            break;
        case 3:
            Console.WriteLine("input 3");
            loop = false;
            break;

        default:
            loop = false;
            break;
    }
}









/* TODO
    "CustomerClient" där kunden genom input/UI kan:
    titta på en lista på alla oköpta matlådor i alla restauranger av en viss typ (kött/fisk/vego), sorterade på pris, lägst först
    välja att köpa en av de lunchlådor som visas
    välja att se de matlådor denne köpt hittils

*/
