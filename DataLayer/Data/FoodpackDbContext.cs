﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Backend;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DataLayer.Data
{
    public class FoodpackDbContext : DbContext
    {
        public DbSet<Ban> Bans { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Foodattribute> Foodattributes { get; set; }
        public DbSet<Foodpackage> Foodpackages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .LogTo(m => Debug.WriteLine(m), LogLevel.Information)
                    .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=FoodpackDbContext");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(user => user.Username)
                .IsUnique();
        }

        public void Seed() 
        {
            var users = new List<User>
            {
                new() {Name = "Anna Andersson" , Username = "AAndersson", Password = "Anna123",},
                new() {Name = "Bertil Bengtsson", Username = "BBengtsson", Password = "Anna123"},
                new() {Name = "Daniel Davidsson" ,Username = "DDavidsson", Password = "Daniel123"},
                new() {Name = "Elin Eriksson" ,Username = "EEriksson", Password = "Elin123"},
                new() {Name = "Frida Fredriksson" ,Username = "FFredriksson", Password = "Frida123" },
                new() {Name = "Gerd Götesson" ,Username = "GGötesson", Password = "Gerd123"},
                new() {Name = "Max",Username = "MaxUsername", Password = "MaxPassword"},
                new() {Name = "McDonalds",Username = "McDonaldsUsername", Password = "McDonaldsPassword"},
                new() {Name = "Subway",Username = "SubwayUsername", Password = "SubwayPassword"},
                new() {Name = "Starbucks",Username = "StarbucksUsername", Password = "StarbucksPassword"},
                new() {Name = "Admin",Username = "AdminUsername", Password = "AdminPassword", IsAdmin = true},

            };
            AddRange(users);

            var restaurants = new List<Restaurant>
            {
                new() {Name = "Max", Phonenumber = "035102030", User = users[6]},
                new() {Name = "McDonalds" , Phonenumber = "03512345", User = users[7]},
                new() {Name = "Subway", User = users[8]},
                new() {Name = "Starbucks", User = users[9]},
            };
            AddRange(restaurants);

            var categories = new Category[]
            {
                new() {Type = "Meat"},
                new() {Type = "Fish"},
                new() {Type = "Veggie"},
            };
            AddRange(restaurants);

            var orders = new Order[]
            {
                new(){OrderDate = DateTime.Today, User = users[2]},
                new(){OrderDate = DateTime.Today, User = users[0]},
                new(){OrderDate = DateTime.Today, User = users[4]},
                
            };
            AddRange(orders);

            var foodattributes = new Foodattribute[]
            {
                new() {Attribute = "Lactose free"},
                new() {Attribute = "Gluten free"},
                new() {Attribute = "Peanuts"},
            };
            AddRange(foodattributes);

            var foodpackages = new List<Foodpackage>
            {
                new(){Description = "Hamburger", Restaurant = restaurants[1], Category = categories[0], Price = 52, ExpireDate = DateTime.Today},
                new(){Description = "Sandwich", Restaurant = restaurants[2], Category = categories[2], Price = 25, ExpireDate = DateTime.Today},
                new(){Description = "Sallad", Restaurant = restaurants[0], Category = categories[0], Price = 59, ExpireDate = DateTime.Today},
                new(){Description = "Sallad", Restaurant = restaurants[0], Category = categories[0], Price = 75, ExpireDate = DateTime.Today},
                new(){Description = "Pokebowl", Restaurant = restaurants[1], Category = categories[1], Price = 67, ExpireDate = DateTime.Today},
                new(){Description = "Sallad", Restaurant = restaurants[3], Category = categories[2], Price = 59, ExpireDate = DateTime.Today},
                new(){Description = "Sallad", Restaurant = restaurants[3], Category = categories[2], Price = 59, ExpireDate = DateTime.Today},
                new(){Description = "Sandwich", Restaurant = restaurants[3], Category = categories[1], Price = 48, ExpireDate = DateTime.Today, Foodattribute = new List<Foodattribute>{foodattributes[1]}},
                new(){Description = "Sandwich", Restaurant = restaurants[2], Category = categories[1], Price = 30, ExpireDate = DateTime.Today, Order = orders[0]},
                new(){Description = "Sandwich", Restaurant = restaurants[3], Category = categories[2], Price = 30, ExpireDate = DateTime.Today, Order = orders[1]},
                new(){Description = "Sallad", Restaurant = restaurants[3], Category = categories[0], Price = 50, ExpireDate = DateTime.Today, Order = orders[2]},
                new(){Description = "Sallad", Restaurant = restaurants[2], Category = categories[0], Price = 50, ExpireDate = DateTime.Today, Order = orders[2]}

            };
            AddRange(foodpackages);

            

            SaveChanges();
        }
    }
}
