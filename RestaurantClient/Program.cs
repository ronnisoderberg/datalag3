using DataLayer.Backend;
using Microsoft.EntityFrameworkCore.Diagnostics;

var restaurant = new RestaurantBackend();
int id = 2;


while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("-------Welcome-------\n");
    Console.ResetColor();
    Console.WriteLine("[1] Get all sold foodpackages");
    Console.WriteLine("[2] Get all unsold foodpackages");
    Console.WriteLine("[3] Add new foodpackage");


    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n[0] Exit");
    Console.ResetColor();
    

    var input = Console.ReadKey();

    if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-------Sold Packages-------\n");
        Console.ResetColor();
        var list = restaurant.GetSoldFoodpacks(id);

        if (list.Count<1)
        {
            Console.WriteLine("The restaurant has not sold any foodpackages yet.");
        }
        else
        {

            foreach (var f in list)
            {
                Console.WriteLine($"Description: {f.Description}\n" +
                                  $"Price: {f.Price}\n" +
                                  $"Expiredate: {f.ExpireDate.Date}\n" +
                                  $"Restaurant: {f.Restaurant.Name}\n" +
                                  $"Sold date: {f.Order.OrderDate}");
                Console.WriteLine("----------------------------");
            }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nPress any key to return to the menu");
        Console.ResetColor();
        Console.ReadKey();

    }

    if (input.Key==ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
    {
        Console.Clear();
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-------Unsold Packages-------\n");
        Console.ResetColor();
        var list = restaurant.GetUnSoldFoodpacks(id);


        foreach (var f in list)
        {
            Console.WriteLine($"Description: {f.Description}\n" +
                              $"Price: {f.Price}\n" +
                              $"Expiredate: {f.ExpireDate.Date}\n" +
                              $"Restaurant: {f.Restaurant.Name}\n");
            Console.WriteLine("------------------------------");
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nPress any key to return to the menu");
        Console.ResetColor();
        Console.ReadKey();

    }

    if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-------Add new package-------\n");
        Console.ResetColor();
        var rest = restaurant.GetRestaurantInfo(id);

        Console.WriteLine($"You are restaurant number {rest.Id}. ({rest.Name})");

        Console.WriteLine("\nEnter description:");
        var description = Console.ReadLine();

        Console.WriteLine("\nEnter price in numbers:");
        var price = Int32.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter expiredate as yyyy/mm/dd");
        var expdate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter category: Fish, Meat or Veggie");
        var category = Console.ReadLine();

        

        restaurant.AddFoodpack(price, expdate, description, id, category);


        Console.WriteLine("\nNew foodpack added!");

        //end of choice
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nPress any key to return to the menu");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();
    }
    if (input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.NumPad0)
    {
        Console.Clear();
        Console.WriteLine("Are you sure you want to exit? y/n");
        input = Console.ReadKey();
        if (input.Key == ConsoleKey.Y)
        {
            break;
        }
    }

}
