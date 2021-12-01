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
            GotoMenu(ConsoleHelp.GetMenuChoice());

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
