using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FoodPackAdder
{
    public static class FoodPackExpireDate
    {
        private static ConsoleHelp help = new ConsoleHelp();
        public static DateTime SetFoodPackExpDate()
        {
            int i = 1;
            SetExpDate:
            Console.Write("Enter expiredate:");
            string date = Console.ReadLine();
            DateTime expdate;
            if (!DateTime.TryParse(date, out expdate))
            {

                help.ClearLastConsoleLine();


                help.ColorWriteLine("The date you have entered is not valid. (yyyy/MM/dd or yyyy-MM-dd)", "red");
                i++;

                goto SetExpDate;
            }
            help.ClearXConsoleLines(i);

            Console.Write("Expire Date:");
            help.ColorWriteLine(expdate.ToShortDateString(), "white");

            return expdate;
        }
    }
}
