using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Backend
{
    public class RestaurantBackend
    {
        private DbContextOptions options;

        public RestaurantBackend(DbContextOptions options)
        {
            this.options = options;
        }


        //requires an User ID
        //and returns the restaurant that this user is managing
        public Restaurant GetRestaurant(int userid)
        {
            using var ctx = new FoodpackDbContext(options);
            return ctx.Restaurants.FirstOrDefault(x => x.User.Id == userid);
        }
        //returns the restaurant with the given ID
        public Restaurant GetRestaurantInfo(int id)
        {
            using var ctx = new FoodpackDbContext(options);
            return ctx.Restaurants.Find(id);
        }
        public List<Foodpackage> GetSoldFoodpacks(int restaurantId)
        {
            var ctx = new FoodpackDbContext(options);

            var query = ctx.Foodpackages
                .Include(f => f.Order)
                .Include(f => f.Restaurant)
                .Where(f => f.Restaurant.Id == restaurantId && f.Order != null)
                .OrderBy(f => f.Restaurant.Id)
                .ToList();

            return query;

        }
        public List<Foodpackage> GetUnSoldFoodpacks(int restaurantId)
        {
            var ctx = new FoodpackDbContext(options);

            var query = ctx.Foodpackages
                .Include(f => f.Order)
                .Include(f => f.Restaurant)
                .Where(f => f.Restaurant.Id == restaurantId && f.Order == null)
                .OrderBy(f => f.Restaurant.Id)
                .ToList();

            return query;

        }

        public void AddFoodpack(int price, DateTime expdate, string description, int restaurant, string category)
        {
            var ctx = new FoodpackDbContext(options);
            var restaurantObject = ctx.Restaurants
                .Where(r => r.Id == restaurant)
                .FirstOrDefault();

            var categoryObject = ctx.Categories
                .Where(c => c.Type == category)
                .FirstOrDefault();

            var newfoodpack = new Foodpackage() {Price = price, ExpireDate = expdate, Description = description, Restaurant = restaurantObject, Category = categoryObject};

            ctx.Foodpackages.Add(newfoodpack);
            ctx.SaveChanges();

        }
        public double GetMonthlyProfit(Restaurant restaurant, DateTime date)
        {
            var ctx = new FoodpackDbContext(options);

            var query = ctx.Foodpackages
                .Include(r => r.Restaurant)
                .Include(o => o.Order)
                .Where(o => o.Order != null && o.Order.OrderDate.Month == date.Month && o.Restaurant == restaurant)
                .Sum(f => f.Price);

            return query;

        }


    }
}
