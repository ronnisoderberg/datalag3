using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Backend;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.FoodPackAdder
{
    public class FoodPackAdd
    {
        private DbContextOptions options;
        public FoodPackAdd(DbContextOptions options)
        {
            this.options = options;
        }

        public void NewFoodPack(Restaurant restaurant)
        {
            var restaurantBackend = new RestaurantBackend(options);
            string description = FoodPackDescription.SetFoodPackDescription();

            int price = FoodPackPrice.SetFoodPackPrice();

            DateTime expdate = FoodPackExpireDate.SetFoodPackExpDate();

            string category = FoodPackCategory.SetFoodPackCategory();

            if (ConfirmFoodPack())
            {
                ConsoleHelp.ClearXConsoleLines(2);
                restaurantBackend.AddFoodpack(price, expdate, description, restaurant.Id, category);
                ConsoleHelp.ColorWriteLine("\nNew foodpack added!", "green");
            }
            else
            {
                ConsoleHelp.ClearXConsoleLines(2);
                ConsoleHelp.ColorWriteLine("\nFoodpack was not added!", "red");
            }

        }


        bool ConfirmFoodPack()
        {
            ConsoleHelp.ColorWriteLine("\nIs the information correct? y/n", "yellow");


            return Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;
        }

    }
}
