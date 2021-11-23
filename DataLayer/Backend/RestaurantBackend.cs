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
        public List<Foodpackage> GetSoldFoodpacks(int restaurantId)
        {
            var ctx = new FoodpackDbContext();

            var query = ctx.Foodpackages
                .Include(f => f.Order)
                .Include(f => f.Restaurant)
                .Where(f => f.Restaurant.Id == restaurantId && f.Order != null)
                .OrderBy(f => f.Restaurant.Id)
                .ToList();

            return query;

        }

        public void AddFoodpack(int price, DateTime expdate, string description, int restaurant, string category)
        {
            var ctx = new FoodpackDbContext();
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
            var ctx = new FoodpackDbContext();

            var query = ctx.Foodpackages
                .Include(r => r.Restaurant)
                .Include(o => o.Order)
                .Where(o => o.Order != null && o.Order.OrderDate.Month == date.Month && o.Restaurant == restaurant)
                .Sum(f => f.Price);

            return query;

        }


    }
}
