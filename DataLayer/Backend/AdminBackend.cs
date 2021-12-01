using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Backend
{
    public class AdminBackend
    {
        private DbContextOptions options;

        public AdminBackend(DbContextOptions options)
        {
            this.options = options;
        }

        //public void PrepDatabase()
        //{
        //    using var ctx = new FoodpackDbContext(options);

        //    ctx.Database.EnsureDeleted();
        //    ctx.Database.EnsureCreated();
        //    ctx.Seed();
        //}

        public List<User> GetAllCostumers()
        {
            var ctx = new FoodpackDbContext(options);

            var query = ctx.Users
                .Include(b => b.Ban)
                .OrderBy(c => c.Id)
                .ToList();

            return query;
        }

        public void BanCostumer(User user, string reason)
        {
            var ctx = new FoodpackDbContext(options);

            var query = ctx.Users
                .Include(b=> b.Ban)
                .Where(c => c == user)
                .FirstOrDefault();

            var ban = new Ban() {User = query, Reason = reason};

            query.Ban.Add(ban);

            query.IsBanned = true;
            ctx.SaveChanges();
        }

        private User GenerateRestaurantLogin(Restaurant restaurant)
        {
            var output = new User()
            {
                Name = restaurant.Name,
                Username = restaurant.Name+"Username",
                Password = restaurant.Name + "Password"
            };
            return output;
        }

        public void AddRestaurant(string name, string phone)
        {
            var ctx = new FoodpackDbContext(options);

            var newRestaurant = new Restaurant() { Name = name, Phonenumber = phone };
            newRestaurant.User = GenerateRestaurantLogin(newRestaurant);
            ctx.Add(newRestaurant);
            ctx.SaveChanges();

        }

        public void LiftBanCostumer(User user)
        {
            var ctx = new FoodpackDbContext(options);

            var ban = ctx.Bans
                .Where(c => c.User == user && c.BannedLift == null)
                .FirstOrDefault();

            if (ban != null)
            {
                ban.BannedLift = DateTime.Today;

                var query = ctx.Users
                    .Include(b => b.Ban)
                    .Where(c => c == user)
                    .FirstOrDefault();

                query.IsBanned = false;
                ctx.SaveChanges();
            }
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            var ctx = new FoodpackDbContext(options);

            var query = ctx.Restaurants
                .Where(r => r.Id == restaurant.Id)
                .FirstOrDefault();

            query.Phonenumber = restaurant.Phonenumber;
            ctx.SaveChanges();
        }
    }
}
