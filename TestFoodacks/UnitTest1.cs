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
    }
}