using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace MainProgramForm
{
    internal class Helper
    {
        public static string GreetAdmin()
        {
            return $"You are signed in as an Admin!";
        }

        public static string GreetRestaurant(Restaurant restaurant)
        {
            return $"Signed in as restaurant: {restaurant.Name} with ID: {restaurant.Id}";
        }

        public static string GreetCustomer(User user)
        {
            return $"You are signed in as {user.Name} the the ID: {user.Id}";
        }
    }
}
