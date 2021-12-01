using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FoodPackAdder
{
    public class FoodPackDescription
    {
        private static ConsoleHelp help = new ConsoleHelp();
        public static string SetFoodPackDescription()
        {
            Console.WriteLine();
            int i = 1;
            SetDescription:
            Console.Write("Enter description:");
            string description = Console.ReadLine();
            if (description.Length < 2)
            {
                help.ClearLastConsoleLine();


                help.ColorWriteLine("The description you have entered is too short. Please try again.", "red");
                i++;
                goto SetDescription;
            }

            //Console.SetCursorPosition(0, Console.CursorTop - 1);
            help.ClearXConsoleLines(i);

            Console.Write("\nDescription:");
            help.ColorWriteLine(description, "white");

            return description;
        }
    }
}
