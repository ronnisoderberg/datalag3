using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using DataLayer.Backend;
using Microsoft.EntityFrameworkCore.Diagnostics;

var restaurant = new RestaurantBackend();
int id = 2;
ConsoleKeyInfo input;


while (true)
{
    Console.Clear();
    ColorWriteLine("-------Welcome-------\n","blue");

    Console.WriteLine("[1] Get all sold foodpackages");
    Console.WriteLine("[2] Get all unsold foodpackages");
    Console.WriteLine("[3] Add new foodpackage");
   
    ColorWriteLine("\n[0] Exit","red");


    input = Console.ReadKey(true);

    if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
    {
        Console.Clear();
        ColorWriteLine("-------Sold Packages-------\n", "blue");
        var list = restaurant.GetSoldFoodpacks(id);


        if (list.Count < 1)
            Console.WriteLine("The restaurant has not sold any foodpackages yet.");
        else
            list.ForEach(x=> Console.WriteLine(x.ToString()));
            

        ColorWriteLine("\nPress any key to return to the menu", "yellow");
        Console.ReadKey();

    }

    if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
    {
        Console.Clear();
       
        ColorWriteLine("-------Unsold Packages-------\n", "blue");
        var list = restaurant.GetUnSoldFoodpacks(id);

        if (list.Count < 1)
            Console.WriteLine("The restaurant does not have any unsold foodboxes.");
        else
            list.ForEach(x => Console.WriteLine(x.ToString()));

            
        ColorWriteLine("\nPress any key to return to the menu","yellow");
        Console.ReadKey();

    }
    if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
    {
        Console.Clear();
        ColorWriteLine("-------Add new package-------\n","blue");
        var rest = restaurant.GetRestaurantInfo(id);

        Console.WriteLine($"You are logged in as restaurant: {rest.Name} with ID: {rest.Id}.");

        NewFoodPack();//todo


        ColorWriteLine("\nPress any key to return to the menu","yellow");
        Console.ReadKey();

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
        if (input.Key == ConsoleKey.N)
        {
            continue;
        }
    }
}


#region NewFoodPackMethods

//method to setup a new foodpackage
void NewFoodPack()
{
    string description = SetFoodPackDescription();

    int price = SetFoodPackPrice();

    DateTime expdate = SetFoodPackExpDate();

    string category = SetFoodPackCategory();

    if (ConfirmFoodPack())
    {
        ClearXConsoleLines(2);
        restaurant.AddFoodpack(price, expdate, description, id, category);
        ColorWriteLine("\nNew foodpack added!","green");
    }
    else
    {
        ClearXConsoleLines(2);
        ColorWriteLine("\nFoodpack was not added!","red");
    }

}

//method to set FoodPack description
string SetFoodPackDescription()
{
    Console.WriteLine();
    int i = 1;
SetDescription:
    Console.Write("Enter description:");
    string description = Console.ReadLine();
    if (description.Length < 2)
    {
        ClearLastConsoleLine();


        ColorWriteLine("The description you have entered is too short. Please try again.", "red");
        i++;
        goto SetDescription;
    }

        //Console.SetCursorPosition(0, Console.CursorTop - 1);
        ClearXConsoleLines(i);

    Console.Write("\nDescription:");
    ColorWriteLine(description, "white");

    return description;
}
//method to set FoodPack price
int SetFoodPackPrice()
{
    int i = 1;
    SetPrice:
    int price = 0;
    Console.Write("Enter price in numbers:");
    if (!Int32.TryParse(Console.ReadLine(), out price))
    {
        ClearLastConsoleLine();

        ColorWriteLine("The price you have entered is not valid.", "red");
        i++;
        goto SetPrice;
    }
    ClearXConsoleLines(i);

    Console.Write("Price:");
    ColorWriteLine(price.ToString(), "white");

    return price;
}
//method to set FoodPack expire date
DateTime SetFoodPackExpDate()
{
    int i = 1;
SetExpDate:
    Console.Write("Enter expiredate:");
    string date = Console.ReadLine();
    DateTime expdate;
    if (!DateTime.TryParse(date, out expdate))
    {

        ClearLastConsoleLine();


        ColorWriteLine("The date you have entered is not valid. (yyyy/MM/dd or yyyy-MM-dd)", "red");
        i++;

        goto SetExpDate;
    }
    ClearXConsoleLines(i);

    Console.Write("Expire Date:");
    ColorWriteLine(expdate.ToShortDateString(), "white");

    return expdate;
}

//method to set FoodPack Category
string SetFoodPackCategory()
{
    int i = 1;
    var categorys = new string[] { "fish", "meat", "veggie" };

SetCategory:
    Console.Write("Enter category:");
    var category = Console.ReadLine();
    if (!categorys.Any(x => x.Equals(category, StringComparison.OrdinalIgnoreCase)))
    {

        ClearLastConsoleLine();


        ColorWriteLine("The category you have entered is invalid. (Fish/Meat/Veggie)", "red");
        i++;
        goto SetCategory;
    }

    ClearXConsoleLines(i);

    Console.Write("Category:");
    ColorWriteLine(category.ToLower(), "white");
    return category;
}

//method to confirm foodpack info is correct
bool ConfirmFoodPack()
{
    ColorWriteLine("\nIs the information correct? y/n", "yellow");


    return Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;
}

#endregion


#region Hjälpmetoder?

//method to print text in color (Console.WriteLine)
void ColorWriteLine(string s, string color)
{
    switch (color)
    {
        case "blue": Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case "red": Console.ForegroundColor = ConsoleColor.Red;
            break;
        case "yellow": Console.ForegroundColor= ConsoleColor.Yellow;
            break;
        case "green":
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case "white": Console.ForegroundColor = ConsoleColor.White;
            break;
        default: Console.ForegroundColor = ConsoleColor.Gray;
            break;
    }
    Console.WriteLine(s);
    Console.ResetColor();
}

//clears the last line of text in the console
void ClearLastConsoleLine()
{
    Console.SetCursorPosition(0, Console.CursorTop-1);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, Console.CursorTop);
}
//clears X lines of text from the console
//accepts amount of lines to clear as parameter
void ClearXConsoleLines(int lines)
{

    for (int j = 0; j < lines; j++)
    {

        Console.SetCursorPosition(0, Console.CursorTop-1);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0,Console.CursorTop);

    }
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



////todo till inlogg
//string GetUsername()
//{
//    GetUsername:
//    Console.Write("Username:");
//    var username = Console.ReadLine();
//    if (username.Length < 2)
//    {
//        Console.SetCursorPosition(0, Console.CursorTop - 1);
//        ClearCurrentConsoleLine();
//        Console.WriteLine("You have entered an invalid username");
//        goto GetUsername;
//    }


//    return username;
//}
//// metod som cencurerer och hämtar lösenordet //Todo till inlogg
//string GetPwdString()
//{
//    var pwd = new StringBuilder();
//    Console.Write("Password:");
//    while (true)
//    {
//        ConsoleKeyInfo key = Console.ReadKey(true);

//        if (key.Key == ConsoleKey.Enter)
//        {
//            break;
//        }
//        else if (key.Key == ConsoleKey.Backspace)
//        {
//            if (pwd.Length > 0)
//            {
//                pwd.Remove(pwd.Length - 1, 1);
//                Console.Write("\b \b");
//            }
//        }
//        else if (key.KeyChar != '\u0000') // KeyChar == '\u0000' if the key pressed does not correspond to a printable character, e.g. F1, Pause-Break, etc
//        {
//            pwd.Append(key.KeyChar);
//            Console.Write("*");
//        }
//    }

//    Console.WriteLine();
//    return pwd.ToString();
//}
#endregion