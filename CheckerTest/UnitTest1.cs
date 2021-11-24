using Xunit;
using DivisorsConsole;
using WebAPI_Divisors;

namespace CheckerTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.False(Service.PrimeNumChecker(0));
            Assert.True(Service.PrimeNumChecker(1));
        }

    }
}