using DataLayer.Backend;

var adminBackend = new AdminBackend();
var userBackend = new UserBackend();

while (true)
{
    Console.Clear();
    Console.WriteLine("Hallo Admin! Select an option below\n");
    Console.WriteLine("[1] Reset database");
    Console.WriteLine("[2] Show all users");
    Console.WriteLine("[3] Show all restaurants");
    Console.WriteLine("[4] Add new restaurants and info");
    Console.WriteLine("[5] Change a restaurants info");

    var readkey = Console.ReadKey();


    if (readkey.Key == ConsoleKey.D1 || readkey.Key == ConsoleKey.NumPad1)
    {
        Console.Clear();
        adminBackend.PrepDatabase();
        Console.WriteLine("Database deleted, created and seeded");
        Console.ReadKey();
    }

    if (readkey.Key == ConsoleKey.D2 || readkey.Key == ConsoleKey.NumPad2)
    {
        Console.Clear();

        var users = adminBackend.GetAllCostumers();
        
        Console.WriteLine("This is all registered users: ");

        foreach (var u in users)
        {
            Console.WriteLine("Name: " + u.Name);
            if (u.IsBanned == true)
                Console.WriteLine("Banned: Yes" + "\n");
            else
                Console.WriteLine("Banned: No" + "\n");
        }

        Console.ReadKey();
    }

    if (readkey.Key == ConsoleKey.D3 || readkey.Key == ConsoleKey.NumPad3)
    {
        Console.Clear();

        var restaurants = userBackend.GetRestaurants();

        foreach (var r in restaurants) Console.WriteLine($"Restaurantname: {r.Name}\n");

        Console.ReadKey();
    }

    if (readkey.Key == ConsoleKey.D4 || readkey.Key == ConsoleKey.NumPad4)
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Type restaurantname or press [0] to go back to menu");
            var name = Console.ReadLine();

            if (name == null || name == "")
            {
                Console.WriteLine("Invalid restaurant name, try again");
                continue;
            }

            if (name == "0") break;

            Console.WriteLine("Type phonenumber (optional)");
            var phone = Console.ReadLine();
            if (phone == "") phone = null;

            adminBackend.AddRestaurant(name, phone);
            Console.Clear();
            Console.WriteLine("Restaurant added!");

            Console.WriteLine("\nAdd more restaurants by press [0]. Any other key return to menu");
            var keyInput = Console.ReadKey();

            if (keyInput.Key != ConsoleKey.D0 || keyInput.Key != ConsoleKey.NumPad0) break;
        }
    }

    if (readkey.Key == ConsoleKey.D5 || readkey.Key == ConsoleKey.NumPad5)
    {
        Console.Clear();

        while (true)
        {
            var restaurants = userBackend.GetRestaurants();
            var restaurantnumber = 1;

            foreach (var r in restaurants)
            {
                Console.WriteLine($"[{restaurantnumber}]\n" +
                                  $"Restaurantname: {r.Name}\n" +
                                  "-----------------------------------");
                restaurantnumber++;
            }

            Console.WriteLine("Type in the restaurantnumber you want to change");
            if (!int.TryParse(Console.ReadLine(), out var selectedRestaurant) || selectedRestaurant > restaurants.Count)
            {
                Console.WriteLine(
                    "Restaurantnumber not found. Press [0] to go back to menu or any other key to try again");
                if (Console.ReadKey().Key == ConsoleKey.D0 || Console.ReadKey().Key == ConsoleKey.NumPad0) break;
                continue;
            }

             //ej färdig, fortsätt på vad som ska ändras
            var restaurantObjekt = restaurants.ElementAtOrDefault(selectedRestaurant - 1);

            Console.WriteLine(restaurantObjekt.Name);
            Console.ReadKey();
        }

        Console.ReadKey();
    }
}