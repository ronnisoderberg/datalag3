using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace RestaurantClient.views
{
    public class LoginMenuChioce
    {
        public static void ShowLoginMenu()
        {
            Console.WriteLine("[1] Get all sold foodpackages");
            Console.WriteLine("[2] Get all unsold foodpackages");
            Console.WriteLine("[3] Add new foodpackage");

            ConsoleHelp.ColorWriteLine("\n[0] Sign Out", "red");

        }
        public static void GotoMenu(ConsoleKeyInfo input)
        {
            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                LoginScreen.RunLoginScreen();
            }
            if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("\nWorking on it =)");
                StandardMessages.ReturnMessage();
            }
            if (input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.NumPad0)
            {
                StandardMessages.ConfirmChoice("exit");
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                {
                    Environment.Exit(0);

                }
                if (input.Key == ConsoleKey.N)
                {
                    return;
                }
            }
        }
    }
}
