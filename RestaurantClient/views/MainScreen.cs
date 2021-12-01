using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using RestaurantClient.views.FoodPackAdder;

namespace RestaurantClient.views
{
    public class MainScreen
    {
        public static void RunMainScreen()
        {
            ConsoleKeyInfo input;
            bool RunProgram = true;
            while (RunProgram)
            {
                StandardMessages.WelcomeMessage();

                MainMenuChoice.ShowMainMenu();

                input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
                {
                    LoginScreen.RunLoginScreen();
                }
                if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)//todo
                {
                    Console.WriteLine("\nWorking on it =)");
                    StandardMessages.ReturnMessage();
                }
                if (input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.NumPad0)//todo
                {
                    RunProgram = ExitChoice();
                }
                bool ExitChoice()
                {
                    StandardMessages.ConfirmChoice("exit");
                    input = Console.ReadKey();
                    if (input.Key == ConsoleKey.Y)
                    {
                        return false;
                    }
                    if (input.Key == ConsoleKey.N)
                    {
                        return true;
                    }

                    return true;
                }
            }

        }


    }

}