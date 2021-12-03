using DataLayer;
using RestaurantClient.views.FoodPackAdder;

namespace RestaurantClient.views
{
    public class MainScreen
    {
        public static void RunMainScreen()
        {

            bool RunProgram = true;
            while (RunProgram)
            {
                StandardMessages.WelcomeMessage();

                MainMenuChoice.ShowMainMenu();
            }

        }


    }

}