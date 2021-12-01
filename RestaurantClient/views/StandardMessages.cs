using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using System.Threading;

namespace DataLayer
{
    public static class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.Clear();
            ConsoleHelp.ColorWriteLine("-------Welcome-------\n", "blue");
        }

        public static void LoginMessage(Restaurant restaurant)
        {
            Console.Clear();
            ConsoleHelp.ColorWriteLine($"Signed in as restaurant: {restaurant.Name} with ID: {restaurant.Id}\n","white");

        }

        public static void PrintUsernameOrPasswordError()
        {
            ConsoleHelp.ColorWriteLine("\nLogin failed!","red");
            ConsoleHelp.ColorWriteLine("Username/password is incorrect or user does not exist", "grey");
             ReturnMessage();
        }

        public static void LoginSuccessMessage()
        {
            ConsoleHelp.ColorWriteLine("Login successful!", "green");
            Thread.Sleep(2000);
        }
        public static void InsufficientPermissionMessage()
        {
            ConsoleHelp.ColorWriteLine($"\nYou are not a manager for any restaurant","red");
            ReturnMessage();
        }

        public static void ReturnMessage()
        {
            ConsoleHelp.ColorWriteLine("\nPress any key to return to the menu", "yellow");
            Console.ReadKey();
        }

        public static void ConfirmChoice(string action)
        {
            Console.Clear();
            Console.WriteLine($"Are you sure you want to {action}? y/n");
        }
    }
}
