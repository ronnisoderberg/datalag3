﻿using System;
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
        public void PrepDatabase()
        {
            using var ctx = new FoodpackDbContext();

            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            ctx.Seed();
        }

        public List<Costumer> GetAllCostumers()
        {
            var ctx = new FoodpackDbContext();

            var query = ctx.Costumers
                .Include(b => b.Ban)
                .OrderBy(c => c.Id)
                .ToList();

            return query;
        }

        public void BanCostumer(Costumer costumer, string reason)
        {
            var ctx = new FoodpackDbContext();

            var query = ctx.Costumers
                .Include(b=> b.Ban)
                .Where(c => c == costumer)
                .FirstOrDefault();

            var ban = new Ban() {Costumer = query, Reason = reason};

            query.Ban.Add(ban);

            query.IsBanned = true;
            ctx.SaveChanges();
        }

        public void AddRestaurant(string name, string phone)
        {
            var ctx = new FoodpackDbContext();

            var newRestaurant = new Restaurant() { Name = name, Phonenumber = phone };

            ctx.Add(newRestaurant);
            ctx.SaveChanges();

            }

        public void LiftBanCostumer(Costumer costumer)
        {
            var ctx = new FoodpackDbContext();

            var ban = ctx.Bans
                .Where(c => c.Costumer == costumer && c.BannedLift == null)
                .FirstOrDefault();

            if (ban != null)
            {
                ban.BannedLift = DateTime.Today;

                var query = ctx.Costumers
                    .Include(b => b.Ban)
                    .Where(c => c == costumer)
                    .FirstOrDefault();

                query.IsBanned = false;
                ctx.SaveChanges();
            }
        }
    }
}