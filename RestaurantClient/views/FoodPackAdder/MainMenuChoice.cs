using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace RestaurantClient.views.FoodPackAdder
{
    public class MainMenuChoice
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("[1] Login as a restaurant");
            Console.WriteLine("[2] Register as a representant of a restaurant");

            ConsoleHelp.ColorWriteLine("\n[0] Exit", "red");
        }

    }
}
