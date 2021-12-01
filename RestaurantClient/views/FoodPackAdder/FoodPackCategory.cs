using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FoodPackAdder
{
    public static  class FoodPackCategory
    {
        public static ConsoleHelp help = new ConsoleHelp();
        //method to set FoodPack Category
        public static string SetFoodPackCategory()
        {
            int i = 1;
            var categorys = new string[] { "fish", "meat", "veggie" };

            SetCategory:
            Console.Write("Enter category:");
            var category = Console.ReadLine();
            if (!categorys.Any(x => x.Equals(category, StringComparison.OrdinalIgnoreCase)))
            {

                help.ClearLastConsoleLine();


                help.ColorWriteLine("The category you have entered is invalid. (Fish/Meat/Veggie)", "red");
                i++;
                goto SetCategory;
            }

            help.ClearXConsoleLines(i);

            Console.Write("Category:");
            help.ColorWriteLine(category.ToLower(), "white");
            return category;
        }
    }
}
