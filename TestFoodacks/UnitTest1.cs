using Xunit;
using DataLayer;
using DataLayer.Backend;
using DataLayer.Data;
using DataLayer.Model;

namespace TestFoodacks
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            var startNseed = new AdminBackend();
            startNseed.PrepDatabase();
        }

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void AddRestaurant()
        {
            var adminBackend = new AdminBackend();
            var userbackend = new UserBackend();
            
            adminBackend.AddRestaurant("test", "");

            var restaurant = userbackend.GetRestaurants().Find(r => r.Name == "test");

            Assert.NotNull(userbackend.GetRestaurants().Find(r => r.Name == "test"));

            Assert.True(userbackend.GetRestaurants().Find(r => r.Name == "test").Phonenumber == null);
            Assert.False(userbackend.GetRestaurants().Find(r => r.Name == "test").Phonenumber == "");
        }
    }
}