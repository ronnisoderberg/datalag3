using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using DataLayer;
using DataLayer.Backend;
using DataLayer.FoodPackAdder;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

var optionsBuilder = new DbContextOptionsBuilder();
optionsBuilder.UseSqlServer(
    "Data Source=(localdb)\\MSSQLLocalDB;Database=FoodpackTestDbContext");

Login login = new Login(optionsBuilder.Options);

StandardMessages message = new StandardMessages();
RestaurantBackend restaurantBackend = new RestaurantBackend(optionsBuilder.Options);
Restaurant restaurant = new Restaurant();
ConsoleHelp help = new ConsoleHelp();

User user;
ConsoleKeyInfo input;

while (true)
{
    bool signedIn = false;
    message.WelcomeMessage();

    Console.WriteLine("[1] Login as a restaurant");
    Console.WriteLine("[2] Register as a representant of a restaurant");

    help.ColorWriteLine("\n[0] Exit", "red");

    input = Console.ReadKey(true);
    
    if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
    {
        Console.Clear();
        help.ColorWriteLine("-------Login-------\n", "blue");

        var username = login.GetUsername();
        var password = login.GetPassword();

        user = login.TryLogin(username, password);
      if (user == null)
          message.PrintUsernameOrPasswordError();
      else if (login.CheckUserAcces(user) == UserAcces.Manager)
      {
          restaurant = restaurantBackend.GetRestaurant(user.Id);
          message.LoginSuccessMessage();
          signedIn = true;
      }
      else
          message.InsufficientPermissionMessage();
    }

    if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
    {
        Console.WriteLine("Not implmented yet.");
        message.ReturnMessage();
    }

    if (input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.NumPad0)
    {
        message.ConfirmChoice("exit");
        input = Console.ReadKey();
        if (input.Key == ConsoleKey.Y)
        {
            break;
        }
        if (input.Key == ConsoleKey.N)
        {
            continue;
        }

    }
    while (signedIn)
    {
        message.LoginMessage(restaurant);

        Console.WriteLine("[1] Get all sold foodpackages");
        Console.WriteLine("[2] Get all unsold foodpackages");
        Console.WriteLine("[3] Add new foodpackage");

        help.ColorWriteLine("\n[0] Sign Out", "red");


        input = Console.ReadKey(true);

        if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
        {
            Console.Clear();
            help.ColorWriteLine("-------Sold Packages-------\n", "blue");
            var list = restaurantBackend.GetSoldFoodpacks(restaurant.Id);


            if (list.Count < 1)
                Console.WriteLine("The restaurant has not sold any foodpackages yet.");
            else
                list.ForEach(x => Console.WriteLine(x.ToString()));


            help.ColorWriteLine("\nPress any key to return to the menu", "yellow");
            Console.ReadKey();

        }

        if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
        {
            Console.Clear();

            help.ColorWriteLine("-------Unsold Packages-------\n", "blue");
            var list = restaurantBackend.GetUnSoldFoodpacks(restaurant.Id);

            if (list.Count < 1)
                Console.WriteLine("The restaurant does not have any unsold foodboxes.");
            else
                list.ForEach(x => Console.WriteLine(x.ToString()));


            help.ColorWriteLine("\nPress any key to return to the menu", "yellow");
            Console.ReadKey();

        }
        if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
        {
            Console.Clear();
            help.ColorWriteLine("-------Add new package-------\n", "blue");
            var rest = restaurantBackend.GetRestaurantInfo(restaurant.Id);

            Console.WriteLine($"You are logged in as restaurant: {rest.Name} with ID: {rest.Id}.");
            var adder = new FoodPackAdd(optionsBuilder.Options);
            adder.NewFoodPack(restaurant);


            message.ReturnMessage();

        }
        if (input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.NumPad0)
        {
            message.ConfirmChoice("sign out");
            input = Console.ReadKey();

            if (input.Key == ConsoleKey.Y)
            {
                signedIn = false;
                break;
            }
            if (input.Key == ConsoleKey.N)
            {
                continue;
            }
        }
    }
}





/*todo skapa klass för innan login och efter login,
i menyvalen sen istället kalla på metoder där all kod finns istället?????

tittade på en video, det fanns två st program.cs
ena internal static void main() där det anslöts till en database

och sen en program.cs som hade UI osv? varför


du gjorde konstruktor i database.cs som tar in options.
behöver man göra en sån för varje backend project?(userbackend/adminbackend etc)

Restaurant manager - går det bra att man gör ett konto till själva restaurangen
istället för att koppla en viss user till restaurangen(det är ändå typ detat vi gör)
-skapar en användare när restaurangen skapas, med restaurangens login uppgifter


*/