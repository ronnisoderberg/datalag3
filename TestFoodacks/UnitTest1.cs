using Xunit;
using DataLayer;
using DataLayer.Backend;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

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
        public void Test1()
        {
            Assert.True(true);
        }
    }
}