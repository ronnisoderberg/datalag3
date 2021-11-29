using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
   
    public class Login
    {
        private DbContextOptions options;

        public Login(DbContextOptions options)
        {
            this.options = options;
        }

        public UserAcces CheckUserAcces(User user)
        {
            using var ctx = new FoodpackDbContext(options);

            if (user.IsAdmin == true)
                return UserAcces.Admin;
            
            if (ctx.Restaurants.Any(r=> r.User.Id==user.Id))
                return UserAcces.Manager;

            return UserAcces.Customer;
        }
        public User TryLogin(string username, string password)//todo make password case sensitive
        {
            using var ctx = new FoodpackDbContext(options);

            return ctx.Users.FirstOrDefault(user => user.Username == username && user.Password == password);
        }
        //metod som hämtar användarnamnet
        public string GetUsername()
        {
            var username = string.Empty;
          
                Console.Write("Username:");
                username = Console.ReadLine();
                return username;
        }
        // metod som cencurerer och hämtar lösenordet
        public string GetPassword()
        {
            var password = new StringBuilder();
            Console.Write("Password:");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password.Remove(password.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else if (key.KeyChar != '\u0000')
                {
                    password.Append(key.KeyChar);
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            return password.ToString();

        }

    }
}
