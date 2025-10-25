using Xunit;
using MathLib;

namespace MathLib.Tests
{
    public class PowerTests
    {
        [Fact(DisplayName = "Power_PositiveExponent_ReturnsCorrectValue_Yan")]
        public void Test1()
        {
            Assert.Equal(8, PowerOps.Power(2, 3));
        }

        [Fact(DisplayName = "Power_ZeroExponent_Returns1_Yan")]
        public void Test2()
        {
            Assert.Equal(1, PowerOps.Power(5, 0));
        }

        [Fact(DisplayName = "Power_NegativeExponent_Throws_Yan")]
        public void Test3()
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => PowerOps.Power(2, -1));
        }
    }
}
