using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Backend;
using DataLayer.Model;

namespace DataLayer.FoodPackAdder
{
    public class FoodPackAdd
    {
        private ConsoleHelp help = new ConsoleHelp();
        private RestaurantBackend restaurantBackend = new RestaurantBackend();

        public void NewFoodPack(Restaurant restaurant)
        {
            string description = FoodPackDescription.SetFoodPackDescription();

            int price = FoodPackPrice.SetFoodPackPrice();

            DateTime expdate = FoodPackExpireDate.SetFoodPackExpDate();

            string category = FoodPackCategory.SetFoodPackCategory();

            if (ConfirmFoodPack())
            {
                help.ClearXConsoleLines(2);
                restaurantBackend.AddFoodpack(price, expdate, description, restaurant.Id, category);
                help.ColorWriteLine("\nNew foodpack added!", "green");
            }
            else
            {
                help.ClearXConsoleLines(2);
                help.ColorWriteLine("\nFoodpack was not added!", "red");
            }

        }


        bool ConfirmFoodPack()
        {
            help.ColorWriteLine("\nIs the information correct? y/n", "yellow");


            return Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;
        }

    }
}
