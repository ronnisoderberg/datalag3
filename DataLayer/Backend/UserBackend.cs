using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Backend
{
    public class UserBackend
    {
        private DbContextOptions options;

        public UserBackend(DbContextOptions options)
        {
            this.options= options;
        }
        public List<Foodpackage> GetFoodpackages(String category)
        {
            var ctx = new FoodpackDbContext(options);

            var query = ctx.Foodpackages
                .Include(f => f.Category)
                .Include(f => f.Restaurant)
                .Include(a => a.Foodattribute)
                .OrderBy(f => f.Price)
                .Where(f => f.Category.Type == category
                && f.Order == null)
                .ToList();

            return query;
        }
       public List<Foodpackage> GetFoodpackagesForCostummer(int id)
        {
            var ctx = new FoodpackDbContext(options);

            var query = ctx.Foodpackages
                .Include(f => f.Category)
                .Include(f => f.Restaurant)
                .Include(a => a.Foodattribute)
                .OrderBy(f => f.Price)
                .Where(f => f.Order.User.Id == id
                && f.Order != null)
                .ToList();

            return query;
        }

       
        //Hämtar Objektet användaren med den unika ID nycklen som finns i tabellen. 
        public User GetCostumer(int id)
        {
            var ctx = new FoodpackDbContext(options);

            return ctx.Users.Find(id);
        }


        public Order BuyFoodpack(List<Foodpackage> orderlist) 
        {
            var ctx = new FoodpackDbContext(options);

            //user is set to ID 1
            var order = new Order() { OrderDate = DateTime.Today, User = ctx.Users.Find(1)};
            double orderPriceSum = 0;

            foreach (var o in orderlist)
            {
                var query = ctx.Foodpackages
                    .Where(f => f.Id == o.Id)
                    .FirstOrDefault();

                orderPriceSum += o.Price;

                query.Order = order;
            }

            order.OrderSum = orderPriceSum;

            ctx.SaveChanges();
            return order;
        }

        public List<Foodpackage> GetOrderedFood(Order order)
        {
            var ctx = new FoodpackDbContext(options);
            var query = ctx.Orders
                .Include(o => o.Foodpackage)
                .ThenInclude(f => f.Restaurant)
                .Where(o => o == order)
                .FirstOrDefault();

            return query.Foodpackage.ToList();
        }

        public List<Restaurant> GetRestaurants()
        {
            var ctx = new FoodpackDbContext(options);

            var query = ctx.Restaurants
                .ToList();

            return query;
        }
    }
}
