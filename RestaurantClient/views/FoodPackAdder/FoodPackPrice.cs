using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FoodPackAdder
{
    public static class FoodPackPrice
    {
        private static ConsoleHelp help = new ConsoleHelp();
        public static int SetFoodPackPrice()
        {
            int i = 1;
            SetPrice:
            int price = 0;
            Console.Write("Enter price in numbers:");
            if (!Int32.TryParse(Console.ReadLine(), out price))
            {
                help.ClearLastConsoleLine();

                help.ColorWriteLine("The price you have entered is not valid.", "red");
                i++;
                goto SetPrice;
            }
            help.ClearXConsoleLines(i);

            Console.Write("Price:");
            help.ColorWriteLine(price.ToString(), "white");

            return price;
        }
    }
}
