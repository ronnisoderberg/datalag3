using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FoodPackAdder
{
    public class FoodPackDescription
    {
        public static string SetFoodPackDescription()
        {
            Console.WriteLine();
            int i = 1;
            SetDescription:
            Console.Write("Enter description:");
            string description = Console.ReadLine();
            if (description.Length < 2)
            {
                ConsoleHelp.ClearLastConsoleLine();


                ConsoleHelp.ColorWriteLine("The description you have entered is too short. Please try again.", "red");
                i++;
                goto SetDescription;
            }

            //Console.SetCursorPosition(0, Console.CursorTop - 1);
            ConsoleHelp.ClearXConsoleLines(i);

            Console.Write("\nDescription:");
            ConsoleHelp.ColorWriteLine(description, "white");

            return description;
        }
    }
}
