using System.Reflection;
using System.Security;
using System.Text;
using DataLayer.Backend;
using Microsoft.EntityFrameworkCore.Diagnostics;

var restaurant = new RestaurantBackend();
int id = 2;
ConsoleKeyInfo input;


bool successfull = false;
bool choice = false;
bool check = true;


    while (!successfull)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-------Welcome-------\n");
        Console.ResetColor();
        Console.WriteLine("[1] Get all sold foodpackages");
        Console.WriteLine("[2] Get all unsold foodpackages");
        Console.WriteLine("[3] Add new foodpackage");


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n[0] Sign out");
        Console.ResetColor();


        input = Console.ReadKey();

        if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------Sold Packages-------\n");
            Console.ResetColor();
            var list = restaurant.GetSoldFoodpacks(id);


            if (list.Count < 1)
                Console.WriteLine("The restaurant has not sold any foodpackages yet.");
            else
                list.ForEach(x=> Console.WriteLine(x.ToString()));
            

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nPress any key to return to the menu");
            Console.ResetColor();
            Console.ReadKey();

        }

        if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------Unsold Packages-------\n");
            Console.ResetColor();
            var list = restaurant.GetUnSoldFoodpacks(id);

            if (list.Count < 1)
                Console.WriteLine("The restaurant does not have any unsold foodboxes.");
            else
                list.ForEach(x => Console.WriteLine(x.ToString()));


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nPress any key to return to the menu");
            Console.ResetColor();
            Console.ReadKey();

        }
        if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
        {
            check = true;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------Add new package-------\n");
            Console.ResetColor();
            var rest = restaurant.GetRestaurantInfo(id);

            Console.WriteLine($"You are logged in as restaurant: {rest.Name} with ID: {rest.Id}.");

            string description = SetFoodPackDescription();

            int price = SetFoodPackPrice();

            DateTime expdate = SetFoodPackExpDate();

            string category = SetFoodPackCategory();

            bool confirm = ConfirmFoodPack();

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

            }
        }
}




//todo till inlogg
string GetUsername()
{
    GetUsername:
    Console.Write("Username:");
    var username = Console.ReadLine();
    if (username.Length<2)
    {
        Console.SetCursorPosition(0,Console.CursorTop-1);
        ClearCurrentConsoleLine();
        Console.WriteLine("You have entered an invalid username");
        goto GetUsername;
    }


    return username;
}
// metod som cencurerer och hämtar lösenordet //Todo till inlogg
string GetPwdString()
{
    var pwd = new StringBuilder();
    Console.Write("Password:");
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.Enter)
        {
            break;
        }
        else if (key.Key == ConsoleKey.Backspace)
        {
            if (pwd.Length > 0)
            {
                pwd.Remove(pwd.Length - 1, 1);
                Console.Write("\b \b");
            }
        }
        else if (key.KeyChar != '\u0000') // KeyChar == '\u0000' if the key pressed does not correspond to a printable character, e.g. F1, Pause-Break, etc
        {
            pwd.Append(key.KeyChar);
            Console.Write("*");
        }
    }

    Console.WriteLine();
    return pwd.ToString();
}

string SetFoodPackDescription()
{
    int i = 0;
    SetDescription:
    Console.Write("\nEnter description:");
    string description = Console.ReadLine();
    if (description.Length < 2)
    {
        Console.SetCursorPosition(0, Console.CursorTop-1);
        ClearCurrentConsoleLine();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The description you have entered is too short. Please try again.");
        i++;
        Console.ResetColor();
        goto SetDescription;
    }

    for (int j = 0; j < i*2+1; j++)
    {
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        ClearCurrentConsoleLine();
    }
    Console.Write("Description:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(description);
    Console.ResetColor();

    return description;
}

int SetFoodPackPrice()
{
    int i = 0;
    SetPrice:
    int price = 0;
    Console.Write("\nEnter price in numbers:");
        if (!Int32.TryParse(Console.ReadLine(), out price))
        {
            Console.SetCursorPosition(0,Console.CursorTop-1);
            ClearCurrentConsoleLine();

            Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The price you have entered is not valid.");
        i++;
        Console.ResetColor();
        goto SetPrice;
        }
        for (int j = 0; j < i * 2 + 1; j++)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
        }
        Console.Write("Price:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(price);
        Console.ResetColor();

    return price;
}

DateTime SetFoodPackExpDate()
{
    int i = 0;
    SetExpDate:
    Console.Write("\nEnter expiredate:");
    string date = Console.ReadLine();
    DateTime expdate;
    if (!DateTime.TryParse(date, out expdate))
    {
        Console.SetCursorPosition(0,Console.CursorTop-1);
        ClearCurrentConsoleLine();


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The date you have entered is not valid. (yyyy/MM/dd or yyyy-MM-dd)");
        Console.ResetColor();
        i++;

        goto SetExpDate;
    }
    for (int j = 0; j < i * 2 + 1; j++)
    {
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        ClearCurrentConsoleLine();
    }
    Console.Write("Expire Date:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(expdate.ToShortDateString());
    Console.ResetColor();

    return expdate;
}

string SetFoodPackCategory()
{
    int i = 0;
    var categorys = new string[] { "fish", "meat", "veggie" };
    SetCategory:
    Console.Write("\nEnter category:");
    var category = Console.ReadLine();
    if (!categorys.Any(x=> x.Equals(category)))
    {
        Console.SetCursorPosition(0,Console.CursorTop-1);
        ClearCurrentConsoleLine();


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The category you have entered is invalid. (Fish/Meat/Veggie)");
        Console.ResetColor();
        i++;
        goto SetCategory;
    }

    for (int j = 0; j < i * 2 + 1; j++)
    {
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        ClearCurrentConsoleLine();
    }
    Console.Write("Category:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(category);
    Console.ResetColor();

    return category;
}

bool ConfirmFoodPack()
{
    throw new NotImplementedException();
}
//clears the current line of text in the console
void ClearCurrentConsoleLine()
{
    int currentLineCursor = Console.CursorTop;
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, currentLineCursor);
}


//todo om man ska ha login
//Console.Clear();
//Console.ForegroundColor = ConsoleColor.Blue;
//Console.WriteLine("-------Welcome-------\n");
//Console.ResetColor();
//Console.WriteLine("[1] Login as a restaurant");
//Console.WriteLine("[2] Register as a representant of a restaurant");


//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine("\n[0] Exit");
//Console.ResetColor();

//input = Console.ReadKey();
//if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
//{
//    Console.Clear();
//    Console.ForegroundColor = ConsoleColor.Blue;
//    Console.WriteLine("-------Login-------\n");
//    Console.ResetColor();
//    var username = GetUsername();

//    var password = GetPwdString();
//    //todo kontrollera username/pw

//}

//if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
//{
//    Console.Clear();
//    Console.ForegroundColor = ConsoleColor.Blue;
//    Console.WriteLine("-------Register-------\n");
//    Console.ResetColor();
//}