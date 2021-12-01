using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using System.Threading;

namespace DataLayer
{
    public class StandardMessages
    {
        private ConsoleHelp help = new ConsoleHelp();
        public void WelcomeMessage()
        {
            Console.Clear();
            help.ColorWriteLine("-------Welcome-------\n", "blue");
        }

        public void LoginMessage(Restaurant restaurant)
        {
            Console.Clear();
            help.ColorWriteLine($"Signed in as restaurant: {restaurant.Name} with ID: {restaurant.Id}\n","white");

        }

        public void PrintUsernameOrPasswordError()
        {
            help.ColorWriteLine("\nLogin failed!","red"); 
            help.ColorWriteLine("Username/password is incorrect or user does not exist", "grey");
            help.ColorWriteLine("\nPress any key to return to the menu", "yellow");
            Console.ReadKey();
        }

        public void LoginSuccessMessage()
        {
            help.ColorWriteLine("Login successful!", "green");
            Thread.Sleep(2000);
        }
        public void InsufficientPermissionMessage()
        {
            help.ColorWriteLine($"\nYou are not a manager for any restaurant","red");
            help.ColorWriteLine("Press any key to return to the menu", "yellow");
            Console.ReadKey();
        }

        public void ReturnMessage()
        {
            help.ColorWriteLine("\nPress any key to return to the menu", "yellow");
            Console.ReadKey();
        }

        public void ConfirmChoice(string action)
        {
            Console.Clear();
            Console.WriteLine($"Are you sure you want to {action}? y/n");
        }
    }
}
