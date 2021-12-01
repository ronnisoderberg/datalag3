using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using DataLayer;
using DataLayer.Backend;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace TestFoodacks
{
    public class UnitTest1
    {
        private DbContextOptions options;
        public UnitTest1()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=FoodpackTestDbContext");

            options = optionsBuilder.Options;
            var database = new Database(options);
            database.PrepDatabase();
            database.SeedTestData();
        }

        [Fact]
        public void AddRestaurant()
        {
            var adminBackend = new AdminBackend(options);
            var userbackend = new UserBackend(options);
            
            adminBackend.AddRestaurant("test", "");

            var restaurant = userbackend.GetRestaurants().Find(r => r.Name == "test");

            Assert.NotNull(userbackend.GetRestaurants().Find(r => r.Name == "test"));

            Assert.True(userbackend.GetRestaurants().Find(r => r.Name == "test").Phonenumber == null);
            Assert.False(userbackend.GetRestaurants().Find(r => r.Name == "test").Phonenumber == "");
        }

        [Fact]
        //test som testar att loginmetoden fungerar 
        public void LoginTest()
        {
            Login login = new Login(options);

            Assert.Null(login.TryLogin("cannotstop","willnotstop"));

            var user = login.TryLogin("AAndersson", "Anna123");
            Assert.NotNull(user);
            Assert.Equal("AAndersson",user.Username);
            Assert.Equal("Anna123",user.Password);
            Assert.NotEqual(user.Username, "NotAAndedrsson");
        }

        [Fact]
        //test som testar användares accesslevel
        public void UserAccesTest()
        {
            Login login = new Login(options);
            var adminUser = login.TryLogin("AdminUsername", "AdminPassword");
            var restaurantUser = login.TryLogin("SubwayUsername", "SubwayPassword");
            var customerUser = login.TryLogin("AAndersson", "Anna123");

            Assert.NotNull(adminUser);
            Assert.NotNull(restaurantUser);
            Assert.NotNull(customerUser);

            var adminAcces = login.CheckUserAcces(adminUser);
            var managerAcces = login.CheckUserAcces(restaurantUser);
            var customerAcces = login.CheckUserAcces(customerUser);

            Assert.Equal(UserAcces.Admin,adminAcces);
            Assert.Equal(UserAcces.Manager,managerAcces);
            Assert.Equal(UserAcces.Customer,customerAcces);

            Assert.NotEqual(UserAcces.Customer, adminAcces);
            Assert.NotEqual(UserAcces.Manager, customerAcces);
            Assert.NotEqual(UserAcces.Admin, managerAcces);
        }

        [Fact]
        //test som testar login.GetUsernameMetoden
        public void GetUsernameTest()
        {
            Login login = new Login(options);

            string expected = "AAndersson\r\n";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(expected);
            Console.SetIn(stringReader);

            login.GetUsername();
            Console.WriteLine("AAndersson");
            var output = stringWriter.ToString().Split(':');
            Assert.Equal("Username",output[0]);
            Assert.Equal(expected, output[1]);

        }

        [Fact]
        //test som testar några metoder i RestaurantBackend
        public void RestauarntBackendTests()
        {
            var restaurantBackend = new RestaurantBackend(options);
            var userBackend = new UserBackend(options);
            //GetRestaurant
            User user;
            using var ctx = new FoodpackDbContext(options);
            user = ctx.Users.FirstOrDefault(x => x.Username == "SubwayUsername");
            
            Restaurant restaurant = restaurantBackend.GetRestaurant(user.Id);
            Assert.NotNull(restaurant);
            Assert.Equal("Subway",restaurant.Name);

            ////////////////////////////////////////////////////////////////////
            /// 
            //testar get sold/unsoldFoodpacks + GetMontlyProfit och UserBackend.B
            var unSold = restaurantBackend.GetUnSoldFoodpacks(restaurant.Id);
            var sold = restaurantBackend.GetSoldFoodpacks(restaurant.Id);

            var unSoldCount = 1;
            var soldCount = 2;

            Assert.Equal(unSold.Count,unSoldCount);
            Assert.Equal(sold.Count,soldCount);
            
            double profit = 80;
            double monthlyProfit = restaurantBackend.GetMonthlyProfit(restaurant, new DateTime(2021, 12, 10));
            Assert.Equal(profit,monthlyProfit);

            List<Foodpackage> f = new List<Foodpackage>()
            {
                ctx.Foodpackages.Find(2)
            };
            userBackend.BuyFoodpack(f);


            monthlyProfit = restaurantBackend.GetMonthlyProfit(restaurant, new DateTime(2021, 12, 10));

            Assert.NotEqual(profit,monthlyProfit);
            Assert.Equal(profit+25, monthlyProfit);

            unSold = restaurantBackend.GetUnSoldFoodpacks(restaurant.Id);
            sold = restaurantBackend.GetSoldFoodpacks(restaurant.Id);
            Assert.Equal(unSold.Count, unSoldCount-1);
            Assert.Equal(sold.Count, soldCount+1);

        }


    }
}