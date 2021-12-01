using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FoodPackAdder
{
    public static class FoodPackExpireDate
    {
        public static DateTime SetFoodPackExpDate()
        {
            int i = 1;
            SetExpDate:
            Console.Write("Enter expiredate:");
            string date = Console.ReadLine();
            DateTime expdate;
            if (!DateTime.TryParse(date, out expdate))
            {

                ConsoleHelp.ClearLastConsoleLine();


                ConsoleHelp.ColorWriteLine("The date you have entered is not valid. (yyyy/MM/dd or yyyy-MM-dd)", "red");
                i++;

                goto SetExpDate;
            }
            ConsoleHelp.ClearXConsoleLines(i);

            Console.Write("Expire Date:");
            ConsoleHelp.ColorWriteLine(expdate.ToShortDateString(), "white");

            return expdate;
        }
    }
}
