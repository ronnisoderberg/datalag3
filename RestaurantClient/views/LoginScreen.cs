using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Backend;
using DataLayer.FoodPackAdder;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace RestaurantClient.views
{
    public class LoginScreen
    {

        public static void RunLoginScreen()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=FoodpackTestDbContext");
            Login login = new Login(optionsBuilder.Options);
            RestaurantBackend restaurantBackend = new RestaurantBackend(optionsBuilder.Options);

            Console.Clear();
            ConsoleHelp.ColorWriteLine("-------Login-------\n", "blue");

            var username = login.GetUsername();
            var password = login.GetPassword();

            User user = login.TryLogin(username, password);
            if (user == null)
                StandardMessages.PrintUsernameOrPasswordError();
            else if (login.CheckUserAcces(user) == UserAcces.Manager)
            {
               Restaurant restaurant = restaurantBackend.GetRestaurant(user.Id);
                StandardMessages.LoginSuccessMessage();
                LoginSucces.AfterLogIn(restaurant);
            }
            else
                StandardMessages.InsufficientPermissionMessage();

        }

        public static void SoldPacksChoice(Restaurant restaurant,RestaurantBackend restaurantBackend)
        {
            Console.Clear();
            ConsoleHelp.ColorWriteLine("-------Sold Packages-------\n", "blue");
            var list = restaurantBackend.GetSoldFoodpacks(restaurant.Id);


            if (list.Count < 1)
                Console.WriteLine("The restaurant has not sold any foodpackages yet.");
            else
                list.ForEach(x => Console.WriteLine(x.ToString()));


            ConsoleHelp.ColorWriteLine("\nPress any key to return to the menu", "yellow");
            Console.ReadKey();

        }
        public static void UnSoldPacksChoice(Restaurant restaurant, RestaurantBackend restaurantBackend)
        {
            Console.Clear();
            ConsoleHelp.ColorWriteLine("-------Sold Packages-------\n", "blue");
            var list = restaurantBackend.GetSoldFoodpacks(restaurant.Id);


            if (list.Count < 1)
                Console.WriteLine("The restaurant has not sold any foodpackages yet.");
            else
                list.ForEach(x => Console.WriteLine(x.ToString()));


            ConsoleHelp.ColorWriteLine("\nPress any key to return to the menu", "yellow");
            Console.ReadKey();
        }

        public static void AddFoodpackChoice(Restaurant restaurant, FoodPackAdd packAdder, RestaurantBackend restaurantBackend)
        {

            Console.Clear();
            ConsoleHelp.ColorWriteLine("-------Add new package-------\n", "blue");
            Console.WriteLine($"You are logged in as restaurant: {restaurant.Name} with ID: {restaurant.Id}.");
            packAdder.NewFoodPack(restaurant);


            StandardMessages.ReturnMessage();
        }
        public static bool SignOutChoice()
        {
            StandardMessages.ConfirmChoice("sign out");
            ConsoleKeyInfo input;
            input = Console.ReadKey();

            if (input.Key == ConsoleKey.Y)
            {
                return false;
            }
            if (input.Key == ConsoleKey.N)
            {
                return true;
            }
            return true;
        }
    }
}
