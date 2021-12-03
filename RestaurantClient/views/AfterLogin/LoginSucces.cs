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
    public class LoginSucces
    {


        public static void AfterLogIn(Restaurant restaurant)
        {
            StandardMessages.LoginMessage(restaurant);

            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=FoodpackTestDbContext");
            RestaurantBackend restaurantBackend = new RestaurantBackend(optionsBuilder.Options);
            var packAdder = new FoodPackAdd(optionsBuilder.Options);


            bool signedIn = true;
            while (signedIn)
            {
                
                ConsoleKeyInfo input;

                StandardMessages.LoginMessage(restaurant);

                LoginMenuChioce.ShowLoginMenu();



                input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
                {
                    LoginScreen.SoldPacksChoice(restaurant, restaurantBackend);
                }

                if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
                {
                    LoginScreen.UnSoldPacksChoice(restaurant,restaurantBackend);
                }
                if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
                {

                    LoginScreen.AddFoodpackChoice(restaurant, packAdder, restaurantBackend);
                }
                if (input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.NumPad0)
                {

                    signedIn = LoginScreen.SignOutChoice();
                }

            }
        }
     

    }
}
